using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class ValidationManager
    {
        public static bool IsValidString(string value)
        {
            if (value != null && value != string.Empty && value.Trim().Length > 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsValidBarcode(string value)
        {
            if (value.Length >= 10)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
