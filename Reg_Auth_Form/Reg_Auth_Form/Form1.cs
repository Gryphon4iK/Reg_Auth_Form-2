using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Auth_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            using(UserContext db = new UserContext())
            {
                User user = new User(textBoxLog.Text, this.GetHashString(textBoxPass.Text), textBoxEmail.Text, "User");
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] bytesHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach (byte b in bytesHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }
    }
}
