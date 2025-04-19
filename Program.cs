using System.Text.RegularExpressions;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    internal static class Program
    {
        public static string GenerateNextCode(string previousCode, string prefix, int codeLength)
        {
            if (string.IsNullOrEmpty(previousCode))
            {
                return prefix + (new string('0', codeLength - prefix.Length) + "1").Substring(codeLength - prefix.Length);
            }
            string numberPart = previousCode.Substring(prefix.Length);
            int nextNumber = int.Parse(numberPart) + 1;
            string nextCode = prefix + nextNumber.ToString().PadLeft(codeLength - prefix.Length, '0');
            return nextCode;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmCategory());
            //Application.Run(new frmLogin());
        }
    }
}