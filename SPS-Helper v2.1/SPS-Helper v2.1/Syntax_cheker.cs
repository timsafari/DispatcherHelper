using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS_Helper
{
    class Syntax_cheker
    {
        public static int Check(string Language, string Text,  out bool passed)
        {
            int result = 0;
            passed = false;

            switch (Language)
            {
                case "MDX":
                    result = Check_MDX(Text, out passed);
                    break;

                case "SQL":
                    result = Check_SQL(Text, out passed);
                    break;

                case "PowerShell":
                    result = Check_PowerShell(Text, out passed);
                    break;
            }


            return result;
        }

        private static int Check_MDX(string Text,  out bool passed)
        {
            int result = 0;
            passed = false;

            return result;
        }

        private static int Check_SQL(string Text, out bool passed)
        {
            int result = 0;
            passed = false;

            return result;
        }

        private static int Check_PowerShell(string Text, out bool passed)
        {
            int result = 0;
            passed = false;

            return result;
        }


    }
}
