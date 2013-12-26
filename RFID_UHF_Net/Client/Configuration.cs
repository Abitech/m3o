using System;
using System.Xml.Serialization;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Reflection;

namespace com.abitech.rfid
{
	public enum Roles { repairForeman = 1, tubeMaster = 4 };

	/// <summary>
	/// Класс, хранящий данные о соединении с сервером в реестре Windows Mobile
	/// После подготовки обновления обязательно обновите номер Build'а!
	/// </summary>
	public class ClientConfiguration
	{
		private string root = "HKEY_CURRENT_USER\\Software\\Abitech\\";
		private string rai =  "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Shell\\Rai\\:MSREMNET\\";
		public string Server;
		public string DeviceKey;
		public string Build;
		public static string DefaultBuild = "162";
		public string Location;
		public string Language;
		public string Team;
		public Roles Role;

		/// <summary>
		/// Вытаскиваем из реестра настройки, необходимые для функционирования клиента
		/// Необходимы являются Server и DeviceKey
		/// Location, Team, Role можно получить запросом с сервера
		/// </summary>
		public ClientConfiguration()
		{
			var remnet = Helper.GetDirectoryName() + "remnet.exe";
			Registry.SetValue(rai, "1", "\"" + remnet + "\"", RegistryValueKind.String);

			Server = GetRegistryValue<string>(root, "Server", String.Empty);
			DeviceKey = GetRegistryValue<string>(root, "DeviceKey", String.Empty);
			Language = GetRegistryValue<string>(root, "Language", "ru");
			Build = GetRegistryValue<string>(root, "Build", DefaultBuild);
		}

		private T GetRegistryValue<T>(string keyName, string valueName, T defaultValue)
		{
			try
			{
				T value = (T)Registry.GetValue(keyName, valueName, defaultValue);
				if (value == null)
				{
					return defaultValue;
				}

				return value;
			}
			catch (Exception e)
			{
				return defaultValue;
			}
		}

		public void Update(DeviceDescription description)
		{
			Location = description.location;
			Team = description.team;
			Role = description.role;
			Save();	
		}

		public void Save()
		{
			Registry.SetValue(root, "Server", Server, RegistryValueKind.String);
			Registry.SetValue(root, "DeviceKey", DeviceKey, RegistryValueKind.String);
			Registry.SetValue(root, "Language", Language, RegistryValueKind.String);
			Registry.SetValue(root, "Build", Build, RegistryValueKind.String);
		}
	}
}