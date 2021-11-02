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

        public Account GetAccByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from tblAccount where userName = '"+ userName +"'");

            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                return acc;
            }
            return null;
        }

        public Account CheckAccStatusByUserName(string userName)
        {
            string query = string.Format("select * from tblAccount where status = 'passive' and userName = '{0}'", userName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                return acc;
            }
            return null;
        }

        public void ChangeAccStatus(string userName)
        {
            string query = string.Format("update tblAccount set status = 'active' where userName = '{0}'", userName);
            DataProvider.Instance.ExecuteQuery(query);
        }

        public bool UpdateAccountInfo(string userName, string displayName, string pass, string newPass)
        {
            //
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccountInfo @userName , @displayName , @passWord , @newPass", new object[] {userName, displayName, pass, newPass });
            return result > 0;
        }

        public DataTable GetListAccount()
        {
            
            string query = "select userName as [User Name], roleId as [Role ID], accountName as [Display Name]" +
                " from tblAccount where status = 'active'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool AddAccount(string userName, int roleId, string accountName, string password)
        {
            string query = string.Format("insert tblAccount (userName, roleId, accountName, password, status) values ('{0}', {1}, '{2}', '{3}', 'active')", userName, roleId, accountName, password);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool RemoveAccount(string userName)
        {
            string query = string.Format("update tblAccount set status = 'passive' where userName = '{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string userName, string displayName, int roleId)
        {
            
            string query = string.Format("update tblAccount set accountName = '{0}', roleId = {1} where userName = '{2}'",displayName, roleId, userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
