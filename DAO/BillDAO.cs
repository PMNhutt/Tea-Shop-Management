using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopManagement.DTO;

namespace TeaShopManagement.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO()
        {

        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }


        //lấy id max vì add thêm billInfo là lấy số lượng bill hiện tại + thêm
        public int GetMAxIDBill()
        {
            
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(id) from tblBill");
            }
            catch
            {
                return 1;
            }
        }

        public void CheckOutBill(int id, float totalPrice)
        {
            string query = "update tblBill set dateCheckOut = GETDATE(), status = 'PAID', " + "totalPrice = "+ totalPrice +" where id= " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        /// <summary>
        /// success : bill ID
        /// fail: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Get_UnPaid_Bill_ID_By_TableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from tblBill where idTable ="+ id + "and status = 'UNPAID'");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public DataTable GetListBillInfo (DateTime checkIn, DateTime checkOut)
        {
            string query = "select t.name as [Table Name], b.totalPrice as [Total Price], b.dateCheckIn as [Date CheckIn], b.dateCheckOut as [Date CheckOut] from tblBill as b, tblTable as t" +
                " where b.dateCheckIn >= '"+ checkIn +"' and b.dateCheckOut <= '"+checkOut +"' " +
                "and b.status = 'PAID' and t.id = b.idTable";
           return DataProvider.Instance.ExecuteQuery(query);

        }
    }
}
