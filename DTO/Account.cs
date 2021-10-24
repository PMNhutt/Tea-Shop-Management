using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopManagement.DTO
{
    public class Account
    {
        private string userName;
        private int roleID;
        private string accountName;
        private string password;

        public string UserName { get => userName; set => userName = value; }
        public int RoleID { get => roleID; set => roleID = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public string Password { get => password; set => password = value; }

        public Account(string userName, int roleID, string accountName, string password)
        {
            this.AccountName = accountName;
            this.UserName = userName;
            this.RoleID = roleID;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.AccountName = row["accountName"].ToString();
            this.UserName = row["userName"].ToString();
            this.RoleID = (int)row["roleID"];
            this.Password = row["password"].ToString();
        }
    }

    
}
