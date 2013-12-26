using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using CodeBetter.Json;
using com.abitech.rfid;
using DamienG.Security.Cryptography;

namespace SmartDeviceProject1
{
	public enum M3ClientInitializationStatus
	{
		Ok = 0,
		ClientConfigurationMissing = 1,
	}

	public partial class Form1 : Form
	{
		String password = "314159";
		String keypressed = String.Empty;

		RfidWebClient web;
		M3ClientInitializationStatus status;
		ClientConfiguration configuration;
		string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\";
		string mainAppFilename = "RFID_UHF_Net";
		string updaterFilename = "RFID_UHF_UPDATER";
		Thread downloadThread;

		/*
		Принудительное включение радиомодема (Phone On) -- не работает.
		[DllImport("cellcore.dll")]
		private static extern int lineSetEquipmentState(IntPtr hLine, int dwState);
		 */

		public Form1()
		{
			InitializeComponent();			

			status = M3ClientInitializationStatus.Ok;
  			configuration = new ClientConfiguration();

			if (configuration.Server == String.Empty || configuration.DeviceKey == String.Empty)
			{
				status = M3ClientInitializationStatus.ClientConfigurationMissing;
			}

			i8n.Init();
			i8n.strings.SetLanguage(configuration.Language);

			web = new RfidWebClient(configuration);

			downloadThread = new Thread(new ThreadStart(() => { CheckUpdates(); }));
			downloadThread.Start();
		}

		public RpcResponse<AppBuild> GetNextCompatibleBuildVersion(AppBuild currentBuild)
		{
			while (true)
			{
				var response = web.GetNextCompatibleBuildVersion(currentBuild);

				if (response.error != null)
				{
					continue;
				}

				return response;
			}
		}

		public bool DownloadBuild(AppBuild currentBuild, string path)
		{
			while (true)
			{
				var response = web.DownloadFile("/json/dev/maint/get/firmwarebuild/", Converter.Serialize(currentBuild), path);

				if (response == false)
				{
					continue;
				}

				return response;
			}
		}

		private void RunAndExit(string path)
		{
			if (downloadThread != null && downloadThread.Join(5000) == false)
			{
				downloadThread.Abort();
			}

			this.LostFocus -= Form1_LostFocus;
			System.Diagnostics.Process.Start(path, "");
			Application.Exit();
		}

		private void Exit()
		{
			if (downloadThread != null && downloadThread.Join(5000) == false)
			{
				downloadThread.Abort();
			}

			this.LostFocus -= Form1_LostFocus;
			Application.Exit();
		}

		/// <summary>
		/// Асинхронное обновление GUI
		/// </summary>
		/// <param name="d"></param>
		private void I(System.Threading.ThreadStart d)
		{
			this.Invoke(d);
		}

		private string ComputeHash(string path)
		{
			Crc32 crc32 = new Crc32();
			String hash = String.Empty;

			using (FileStream fs = File.Open(path, FileMode.Open))
			{
				foreach (byte b in crc32.ComputeHash(fs))
				{
					hash += b.ToString("x2").ToLower();
				}
			}

			return hash;
		}
		private void CheckUpdates()
		{
			I(delegate() { this.Text = i8n.strings["Build"] + " №" + configuration.Build; });

			DebugMessageBox.Show("DEBUG mode is ON");

			if (status == M3ClientInitializationStatus.ClientConfigurationMissing)
			{
				I(delegate() {
					notificationLabel.Text = i8n.strings["technicalAssistanceNeeded"];
					RunAndExit(directory + mainAppFilename + ".exe");
				});
				return;
			}
			else if (status == M3ClientInitializationStatus.Ok)
			{
				I(delegate(){notificationLabel.Text = i8n.strings["checkingLatestUpdate"];});
			}

			var currentBuild = new AppBuild { build = configuration.Build };

			var nextBuild = GetNextCompatibleBuildVersion(currentBuild).result;

			if (currentBuild.build == nextBuild.build
				&& File.Exists(directory + mainAppFilename + ".exe")
				&& ComputeHash(directory + mainAppFilename + ".exe") == nextBuild.hash
				)
			{
				I(delegate() {
					notificationLabel.Text = i8n.strings["currentBuildMostUpdated"];
					RunAndExit(directory + mainAppFilename + ".exe");
				});
				return;
			}
			else
			{
				I(delegate() { notificationLabel.Text = i8n.strings["downloadingNewBuild"];});
			}

			var extension = String.Empty;

			if (nextBuild.updateType == "1")
			{
				extension = ".exe";
			}
			else if (nextBuild.updateType == "2")
			{
				extension = ".cab";
			}
			var i = 1;

			while (true)
			{
				DownloadBuild(currentBuild, directory + mainAppFilename + extension);
				var downloadedBuildhash = ComputeHash(directory + mainAppFilename + extension);

				if (downloadedBuildhash == nextBuild.hash)
				{
					I(delegate() { notificationLabel.Text = i8n.strings["startProgram"]; });
					break;
				}
				else
				{
					File.Delete(directory + mainAppFilename + extension);
					I(delegate() { notificationLabel.Text = i8n.strings["crcCorrupted"] + "\n" + nextBuild.hash + "—" + downloadedBuildhash + "\n(Попытка " + i++ + ") "; });
				}
			}

			I(delegate() { RunAndExit(directory + mainAppFilename + extension); }); 
		}

		private void Form1_LostFocus(object sender, EventArgs e)
		{
			this.Activate();
		}

		private void IDDQD(object sender, KeyPressEventArgs e)
		{
			keypressed += e.KeyChar.ToString();
			
			if (keypressed.Contains(password))
			{
				keypressed = String.Empty;
				Exit();
			}
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = false;
			this.Activate();
		}
	}
}