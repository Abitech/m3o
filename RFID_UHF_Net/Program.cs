using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RFID_UHF_Net.Forms;

namespace RFID_UHF_Net
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new MainForm());
        }
    }
}