using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopManagement.DTO;

namespace TeaShopManagement.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int tableH = 93;
        public static int tableW = 93;

        private TableDAO()
        {

        }
        //không xài kiểu Datatable được, mấy này chỉ xài cho DatagridView/ combobox thôi
        //flow này phải có thêm class trong DTO
        public List<Table> LoadTable()
        {
            List<Table> list = new List<Table>();
            //load list from csdl
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            //convert datatable to list<>
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                list.Add(table);
            }

            return list;
        }

        public void UpdateTableStatus(int id)
        {
            string query = "update tblTable set status = 'Empty' where id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void UpdateTableStatusToBusy(int id)
        {
            string query = "update tblTable set status = 'Occupied' where id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int CheckOccupiedTable()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select status from tblTable where status = 'Occupied'");

            if (data.Rows.Count > 0)
            {
                return 1;
            }
            return -1;
        }
    }
}
