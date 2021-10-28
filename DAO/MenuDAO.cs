using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopManagement.DTO;

namespace TeaShopManagement.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO()
        {

        }

        public List<Menu> GetListMenuByTable (int id)
        {
            List<Menu> list = new List<Menu>();

            string query = "select f.name,binfo.count,f.price, f.price*binfo.count as totalprice  " +
                "from tblBillInfo as binfo, tblBill as bill, tblFoods as f " +
                "where binfo.idBill = bill.id and binfo.idFood = f.id and bill.status = 'UNPAID' and bill.idTable = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                list.Add(menu);
            }

            return list;
        }

        public List<Menu> GetListPaidMenuByIdBill(int id)
        {
            List<Menu> list = new List<Menu>();

            string query = "select f.name,binfo.count,f.price, f.price*binfo.count as totalprice  " +
                "from tblBillInfo as binfo, tblBill as bill, tblFoods as f " +
                "where binfo.idBill = bill.id and binfo.idFood = f.id and bill.status = 'PAID' and bill.id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                list.Add(menu);
            }

            return list;
        }
    }
}
