using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timber_shop_manager.objects;
using Microsoft.Data.SqlClient;

namespace timber_shop_manager
{
    public partial class frmChangePW : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private Account account;
        private int verificationCode;
        private DateTime expirationTime;
        public frmChangePW(Account acc)
        {
            this.account = acc;
            InitializeComponent();
            txtGmail.Text = acc.Username;
            txtGmail.Enabled = false;
        }
        public frmChangePW()
        {
            InitializeComponent();
        }
        #endregion
        #region Support methods
        private void checkVerifyCode()
        {
            if (DateTime.Now > expirationTime)
            {
                lbCodeWarning.Text = "Mã xác thực đã hết hạn. Vui lòng gửi lại mã xác thực mới.";
                txtCode.Clear();
            }
            else if (txtCode.Text == verificationCode.ToString())
            {
                pnNewPassword.Visible = true;
                pnCode.Visible = false;
                btnSave.Visible = true;
            }
            else
            {
                lbCodeWarning.Text = "Mã xác thực không chính xác. Vui lòng kiểm tra lại.";
                txtCode.Clear();
            }
        }
        private void sendEmail()
        {
            string email = "ph18122005@gmail.com";
            string appPassword = "kbsifafkyvvpjpjt"; // Use App Password for Gmail
            string smtpHost = "smtp.gmail.com";

            // Generate 6-digit verification code
            Random random = new Random();
            verificationCode = random.Next(100000, 999999);

            string subject = "Your Verification Code";
            string body = $"Hello {txtGmail.Text},\n\nYour verification code is: {verificationCode}\n\nPlease use this code to proceed with changing your password.\n\nThank you.";

            try
            {
                using (SmtpClient smtpClient = new SmtpClient(smtpHost))
                using (MailMessage mailMessage = new MailMessage())
                {
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential(email, appPassword); // Use app password
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                    mailMessage.From = new MailAddress(email);
                    mailMessage.To.Add(txtGmail.Text + "@gmail.com"); // Validate user input more carefully
                    mailMessage.Subject = subject;
                    mailMessage.Body = body;

                    smtpClient.Send(mailMessage);
                }

                MessageBox.Show("Verification code sent successfully. Please check your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnCode.Visible = true;
            }
            catch (SmtpException smtpEx)
            {
                // Handle specific SMTP-related errors (e.g., server timeout, authentication issues)
                MessageBox.Show($"SMTP error: {smtpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other errors (e.g., network issues)
                MessageBox.Show($"Failed to send verification code. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        #region Events
        #region Load
        private void frmChangePW_Load(object sender, EventArgs e)
        {
            pnCode.Visible = false;
            pnNewPassword.Visible = false;
            btnSave.Visible = false;
            lbCodeCountdown.Visible = false;
        }
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            sendEmail();
            btnSendEmail.Visible = false;
            lbCodeCountdown.Visible = true;
            expirationTime = DateTime.Now.AddMinutes(1);
            codeExpiration.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lbNewPasswordAgainWarning.Text = String.Empty;

            if (txtNewPassword.Text == txtNewPasswordAgain.Text)
            {
                string query = "UPDATE Account SET Password = @newPass WHERE Username = @user";
                dbHelper.ExecuteNonQuery(query,
                    new SqlParameter("@newPass", txtNewPassword.Text),
                    new SqlParameter("@user", txtGmail.Text));
            }
            else
            {
                lbNewPasswordAgainWarning.Text = "Mật khẩu không khớp. Vui lòng kiểm tra lại.";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Key Press
        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CheckInputIsDigit(e);
        }
        #endregion
        #region Text Change

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text.Length == txtCode.MaxLength)
            {
                checkVerifyCode();
            }
        }
        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Length < 8)
            {
                lbNewPasswordWarning.Text = "Mật khẩu ít nhất 8 kí tự";
            }
            else if (!txtNewPassword.Text.Any(char.IsUpper))
            {
                lbNewPasswordWarning.Text = "Mật khẩu ít nhất phải có 1 kí tự in hoa";
            }
            else if (!Program.ContainsSpecialCharacter(txtNewPassword.Text))
            {
                lbNewPasswordWarning.Text = "Mật khẩu ít nhất phải có 1 kí tự đặc biệt";
            }
            else
            {
                lbNewPasswordWarning.Text = String.Empty;
            }
        }
        #endregion
        #region Tick
        private void codeExpiration_Tick(object sender, EventArgs e)
        {
            TimeSpan timeLeft = expirationTime - DateTime.Now;

            if (timeLeft.TotalSeconds <= 0)
            {
                codeExpiration.Stop();
                lbCodeCountdown.Visible = false;
                btnSendEmail.Visible = true;
                btnSendEmail.Text = "Gửi mã xác thực";
            }
            else
            {
                lbCodeCountdown.Text = $"Mã hết hạn sau: {timeLeft.Minutes:D2}:{timeLeft.Seconds:D2}";
            }
        }
    }
    #endregion
    #endregion
}
