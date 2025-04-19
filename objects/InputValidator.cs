using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace timber_shop_manager.objects
{
    internal class InputValidator
    {
        public static bool ValidateNotEmpty(Dictionary<Control, Label> controlLabelPairs)
        {
            foreach (var pair in controlLabelPairs)
            {
                Control control = pair.Key;
                Label label = pair.Value;

                string value = string.Empty;

                if (control is TextBox textbox)
                {
                    value = textbox.Text.Trim();
                }
                else if (control is ComboBox combobox)
                {
                    value = combobox.Text.Trim();
                }

                if (string.IsNullOrEmpty(value))
                {
                    MessageBox.Show($"Không được bỏ trống {label.Text}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return false;
                }
            }

            return true;
        }

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
    }
}
