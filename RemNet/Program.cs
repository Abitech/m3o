using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace RemNet
{
	/// <summary>
	/// Пустое приложения для подавления сообщений об ошибках соединения с интернетом
	/// См. ClientConfiguration()
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			//DO NOTHING
			/*
            string message = "OurRemNet called with:\r\n";

            foreach (string arg in args)
            {
                message += arg + "\r\n";
            }

            MessageBox.Show(message);

            string repeatparams = "";

            foreach (string arg in args)
            {
                repeatparams += arg + " ";
            }

            Process.Start(@"\Windows\RemNet.exe", repeatparams);
#else
			bool forwardToRemNet = true;

			foreach (string arg in args)
			{
				if (arg == "-RASERROR")
				{
					forwardToRemNet = false;
				}
			}

			if (forwardToRemNet)
			{
				string repeatparams = "";

				foreach (string arg in args)
				{
					repeatparams += arg + " ";
				}
				Process.Start(@"\Windows\RemNet.exe", repeatparams);
			}
#endif
			*/
		}
	}
}
