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

            if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) && c != (char)8)
            {
                e.Handled = true;
            }
        }
        public static string GenerateNextCode(string previousCode, string prefix, int codeLength)
        {
            // Nếu mã trước là null, tạo mã đầu tiên bắt đầu từ 1
            if (string.IsNullOrEmpty(previousCode))
            {
                // Tạo mã đầu tiên với định dạng "prefix0001" nếu codeLength là 4
                return prefix + (new string('0', codeLength - prefix.Length) + "1").Substring(codeLength - prefix.Length);
            }

            // Tách số từ mã trước (giả sử mã có dạng prefixXXXX)
            string numberPart = previousCode.Substring(prefix.Length);

            // Chuyển phần số sang int và cộng thêm 1
            int nextNumber = int.Parse(numberPart) + 1;

            // Sinh mã tiếp theo, đảm bảo chiều dài của mã bằng codeLength
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
            Application.Run(new frmConfig());
            //Application.Run(new frmLogin());
        }
    }
}