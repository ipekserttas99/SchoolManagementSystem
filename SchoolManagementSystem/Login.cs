using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            UNameTb.Text = string.Empty;
            PasswordTb.Text = string.Empty;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == string.Empty || PasswordTb.Text == string.Empty)
            {
                MessageBox.Show("Kullanıcı adı ve şifre giriniz!");
            }
            else if (UNameTb.Text == "Admin" || PasswordTb.Text == "Password")
            {
                MainMenu menu = new MainMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı ya da şifre girdiniz!");
                UNameTb.Text = string.Empty;
                PasswordTb.Text = string.Empty;
            }
        }
    }
}
