using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Auth_Form
{
    public partial class UserForm : Form
    {
        private UserForm form1;

        public UserForm()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                foreach (User user in db.Users)
                {
                    if (textBoxLog.Text == user.Login && this.GetHashString(textBoxPass.Text) == user.Password)
                    {
                        MessageBox.Show("Вход успешен!");
                        UserForm userForm = new UserForm();
                        userForm.label1.Text = user.Login;
                        userForm.Show();
                        userForm.form1 = this;
                        this.Visible = false;
                        return;
                    }
                }
                MessageBox.Show("Логин или пароль указан неверно!");
            }
        }

        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] bytesHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach(byte b in bytesHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }

        private void buttonSendPassword_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("zaid-mingaliev@mail.ru", "Zaid");
            MailAddress to = new MailAddress();
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Тест";
            using (UserContext db  = new UserContext())
            {
                foreach (User user in db.Users)
                {
                    if (textBoxEmail.Text == user.Email)
                    {
                        m.Body = "<h1>Пароль: " + user.Password + "</h1>";
                    }
                }
            }
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential("zaid - mingaliev@mail.ru", "123");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
