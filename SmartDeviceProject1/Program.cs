using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using com.abitech.rfid;

namespace SmartDeviceProject1
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[MTAThread]
		static void Main()
		{
			FileStream fs;
			if (Helper.Lock(out fs) == false)
			{
				MessageBox.Show("Программа АСКОУ уже запущена.");
				return;
			}

			Application.Run(new Form1());
			fs.Close();
		}
	}
}