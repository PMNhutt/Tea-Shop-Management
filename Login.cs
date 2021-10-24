using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaShopManagement.DAO;
using TeaShopManagement.DTO;

namespace TeaShopManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?","Exit!",MessageBoxButtons.OKCancel) !=
                System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUserName.Text;
            string password = txtBoxPass.Text;
            if (CheckLogin(username, password) == true)
            {
                //bấm login thì form login tắt form này mở lên
                Tea_Shop_Management form = new Tea_Shop_Management();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }

        bool CheckLogin(string username, string password)
        {
            return AccountDAO.Instance.Login(username,password);
        }
    }
}
