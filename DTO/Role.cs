using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopManagement.DTO
{
    public class Role
    {
        private int roleId;
        private string roleName;
  
        public int RoleId { get => roleId; set => roleId = value; }
        public string RoleName { get => roleName; set => roleName = value; }

        public Role(int roleId, string roleName)
        {
            this.RoleId = roleId;
            this.roleName = roleName;
        }

        public Role(DataRow row)
        {
            this.RoleId = (int)row["roleId"];
            this.roleName = row["roleName"].ToString();
        }
    }
}
