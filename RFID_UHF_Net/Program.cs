using System;
using System.Collections.Generic;
using System.Windows.Forms;
using com.abitech.rfid.Forms;
using System.Threading;
using System.IO;

namespace com.abitech.rfid
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
            Application.Run(new MainForm());
			fs.Close();
        }
    }
}