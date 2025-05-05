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
using System.Security.Cryptography;
using ReaLTaiizor.Controls;
using timber_shop_manager.BUS;
using timber_shop_manager.DTO;

namespace timber_shop_manager
{
    public partial class frmChangePW : Form
    {
        #region Properties
        private Form form;
        private string email;
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private AccountDTO account;
        private int verificationCode;
        private DateTime expirationTime;
        public frmChangePW()
        {
            InitializeComponent();
        }
        public frmChangePW(Form form) : this()
        {
            this.form = form;
        }
        public frmChangePW(Form form, string email) : this()
        {
            this.form = form;
            this.email = email;
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
                lbCodeCountdown.Visible = false;
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

            string subject = "Mã email xác thực";
            string body = $"Xin chào {txtGmail.Text},\n\nMã xác thực của bạn là: {verificationCode}\n\nVui lòng sử dụng mã xác thực trên để đăng nhập trong một phút nhận được email này \n\nCảm ơn.";

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
                    mailMessage.To.Add(txtGmail.Text); // Validate user input more carefully
                    mailMessage.Subject = subject;
                    mailMessage.Body = body;

                    smtpClient.Send(mailMessage);
                }

                MessageBox.Show("Mã xác thực đã được gửi thành công. Vui lòng kiểm tra email của bạn.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnCode.Visible = true;
            }
            catch (SmtpException smtpEx)
            {
                // Xử lý các lỗi liên quan đến SMTP cụ thể (ví dụ: hết thời gian chờ máy chủ, vấn đề xác thực)
                MessageBox.Show($"Lỗi SMTP: {smtpEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác (ví dụ: vấn đề mạng)
                MessageBox.Show($"Không thể gửi mã xác thực. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                pnCode.Visible = true;
            }
        #endregion
        #region Load
        private void frmChangePW_Load(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true;
            txtNewPasswordAgain.UseSystemPasswordChar = true;
            pbInvisible_newPW.Visible = false;
            pbInvisible_rePW.Visible = false;

            lbCodeCountdown.Text = String.Empty;
            lbCodeWarning.Text = String.Empty;
            lbNewPasswordWarning.Text = String.Empty;
            lbNewPasswordAgainWarning.Text = String.Empty;

            if (form is frmUser || form is frmAccount)
            {
                txtGmail.Text = email;
                txtGmail.Enabled = false;
            }
            btnSave.Visible = false; 
            pnCode.Visible = false;
            pnNewPassword.Visible = false;
        }
        #endregion
        #region Click
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            btnSendEmail.Visible = false;
            lbCodeCountdown.Visible = true;
            sendEmail();
            expirationTime = DateTime.Now.AddMinutes(1);
            codeExpiration.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lbNewPasswordAgainWarning.Text = String.Empty;

            if (txtNewPassword.Text == txtNewPasswordAgain.Text)
            {
                AccountBUS accountBUS = new();
                accountBUS.ChangePassword(txtGmail.Text, txtNewPassword.Text);

                this.Close();
                form.Show();
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
        private void pbVisible_newPW_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = false;
            pbVisible_newPW.Visible = false;
            pbInvisible_newPW.Visible = true;
        }
        private void pbVisible_rePW_Click(object sender, EventArgs e)
        {
            txtNewPasswordAgain.UseSystemPasswordChar = false;
            pbVisible_rePW.Visible = false;
            pbInvisible_rePW.Visible = true;
        }


        private void pbInvisible_newPW_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true;
            pbInvisible_newPW.Visible = false;
            pbVisible_newPW.Visible = true;
        }

        private void pbInvisible_rePW_Click(object sender, EventArgs e)
        {
            txtNewPasswordAgain.UseSystemPasswordChar = true;
            pbInvisible_rePW.Visible = false;
            pbVisible_rePW.Visible = true;
        }
        #endregion
        #region Key Press
        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.CheckInputIsDigit(e);
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
                btnSendEmail.Text = "Gửi lại mã xác thực";
            }
            else
            {
                lbCodeCountdown.Text = $"Mã hết hạn sau: {timeLeft.Minutes:D2}:{timeLeft.Seconds:D2}";
            }
        }
    }
    #endregion

}
