using System;

using System.Collections.Generic;
using System.Text;

namespace RFID_UHF_Net
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

            catch(Exception Ex)
            {
                return false;
            }
        }
    }
}
