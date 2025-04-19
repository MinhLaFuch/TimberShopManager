using System.Text.RegularExpressions;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    internal static class Program
    {
        public static bool ContainsSpecialCharacter(string text)
        {
            // This pattern checks for any character that is NOT a letter or digit
            return Regex.IsMatch(text, @"[^a-zA-Z0-9]");
        }
        public static void CheckInputIsDigit(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // Ngừng sự kiện nếu ký tự không hợp lệ
            }
        }
        public static void CheckInputIsLetter(KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetter(c) && c != (char)8 && c != ' ')
            {
                e.Handled = true;
            }
        }

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

        public static string CapitalizeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return string.Empty;

            name = name.Trim().ToLower();
            var words = name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.Length > 0)
                {
                    words[i] = char.ToUpper(word[0]) + word.Substring(1);
                }
            }

            return string.Join(" ", words);
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
            Application.Run(new frmEmployee());
            //Application.Run(new frmLogin());
        }
    }
}