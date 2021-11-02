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
    public partial class AccountInfo : Form
    {
        public AccountInfo(Account acc)
        {
            InitializeComponent();
            LoadAccInfo(acc);
        }

        void LoadAccInfo(Account acc)
        {
            txtBoxUserName.Text = acc.UserName;
            txtBDisplayName.Text = acc.AccountName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            string userName = txtBoxUserName.Text;
            string displayName = txtBDisplayName.Text;
            string passWord = txtBoxPass.Text;
            string newPass = txtBNewPass.Text;
            string rePass = txtBRePass.Text;

            // update Display Name -> enter displayName, enter passWod to confirm
            // update Password -> enter oldPass, then new pass, then re enter new pass
            if (!rePass.Equals(newPass))
            {
                MessageBox.Show("Confirm pass word failed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccountInfo(userName, displayName, passWord, newPass))
                {
                    MessageBox.Show("Update Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong pass word!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExitInfo_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
