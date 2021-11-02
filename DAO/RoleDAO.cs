using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopManagement.DTO;

namespace TeaShopManagement.DAO
{
    public class RoleDAO
    {
        private static RoleDAO instance;

        public static RoleDAO Instance
        {
            get { if (instance == null) instance = new RoleDAO(); return RoleDAO.instance; }
            private set { RoleDAO.instance = value; }
        }

        private RoleDAO()
        {

        }

        public Role GetRoleById (int id)
        {
            Role getRole = null;

            string query = string.Format("select * from tblRoles where roleId = {0}", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                getRole = new Role(item);
                return getRole;
            }

            return getRole;
        }

        public List<Role> GetListRole()
        {
            List<Role> list = new List<Role>();

            string query = "select * from tblRoles";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Role role = new Role(item);
                list.Add(role);
            }
            return list;
        }
    }
}
