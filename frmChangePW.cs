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

namespace timber_shop_manager
{
    public partial class frmChangePW : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private Account account;
        private int verificationCode;
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
            if (txtCode.Text == verificationCode.ToString())
            {
                pnNewPassword.Visible = true;
                pnCode.Visible = false;
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
            string password = "kbsifafkyvvpjpjt";
            string smtpHost = "smtp.gmail.com"; // or your provider

            // Generate 6-digit code
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
                    smtpClient.Credentials = new NetworkCredential(email, password);
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                    mailMessage.From = new MailAddress(email, password);
                    mailMessage.To.Add(txtGmail.Text + "@gmail.com"); // safer than assuming @gmail.com
                    mailMessage.Subject = subject;
                    mailMessage.Body = body;

                    smtpClient.Send(mailMessage);
                }

                MessageBox.Show("Verification code sent successfully. Please check your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnCode.Visible = true;
            }
            catch (Exception ex)
            {
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
        }
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            sendEmail();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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
        #endregion
        #endregion
    }
}
