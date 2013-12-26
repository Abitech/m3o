using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace com.abitech.rfid
{

    /// <summary>
    /// TODO:устранить ошибку при создании extension method'а TryParse(this string @string)...
    /// </summary>
    public static class Helper
    {
        public static bool TryParse(string @string)
        {
            try
            {
                Int32.Parse(@string);
                return true;
            }

            catch(Exception e)
            {
                return false;
            }
        }
		/// <summary>
		/// Блокировка повторного запуска программы
		/// </summary>
		/// <param name="fs"></param>
		/// <returns></returns>
		public static bool Lock(out FileStream fs)
		{
			try
			{
				fs = new FileStream(GetDirectoryName() + "__lock__", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
				return true;
			}
			catch
			{
				fs = null;
				return false;
			}
		}

		public static string GetDirectoryName()
		{
			return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\";
		}


    }

	public class DebugMessageBox
	{
		public static void Show(string text)
		{
#if DEBUG
			MessageBox.Show(text);
#endif
		}
	}
}
