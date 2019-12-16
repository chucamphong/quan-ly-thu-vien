using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace Core.Validation
{
    public class Validation
    {
        public static bool IsEmail(string email)
        {
            EmailAddressAttribute emailChecker = new EmailAddressAttribute();

            return emailChecker.IsValid(email);
        }

        /// <summary>
        /// Báo lỗi cho người dùng.
        /// </summary>
        /// <param name="textBox">Textbox cần đổi màu.</param>
        /// <param name="lblError">Label để hiển thị tin nhắn lỗi.</param>
        /// <param name="message">Tin nhắn lỗi.</param>
        public static void SetErrorTextBox(GunaTextBox textBox, Label lblError, string message)
        {
            textBox.BorderColor = textBox.FocusedBorderColor = CustomColor.Mandy;
            lblError.Text = message;
        }

        /// <summary>
        /// Xóa báo lỗi.
        /// </summary>
        /// <param name="textBox">Textbox cần xóa màu.</param>
        /// <param name="lblError">Label cần xóa tin nhắn lỗi.</param>
        public static void ClearErrorTextBox(GunaTextBox textBox, Label lblError)
        {
            textBox.BorderColor = textBox.FocusedBorderColor = CustomColor.MineShaft;
            lblError.Text = string.Empty;
        }
    }
}
