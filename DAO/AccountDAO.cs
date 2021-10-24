using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopManagement.DTO;

namespace TeaShopManagement.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO()
        {

        }

        public bool Login(string username, string password)
        {            
           
            
            DataTable result = DataProvider.Instance.LoginExecuteQuery(username,password);
            if (result.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        
    }
}
