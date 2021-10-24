using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopManagement.DTO;

namespace TeaShopManagement.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO()
        {

        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBIll , @idFood , @count", new object[] { idBill,idFood,count });
        }

        public void DeleteBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_DeleteBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }

        public List<BillInfo> GetListBillInfo (int id)
        {
            List<BillInfo> list = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from tblBillInfo where idBill = " + id);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                list.Add(info);
            }
            return list;
        }
    }
}
