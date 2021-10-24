using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopManagement.DTO
{
    public class BillInfo
    {
        private int id;
        private int iDBIll;
        private int iDFood;
        private int count;

        public int IDBIll { get => iDBIll; set => iDBIll = value; }
        public int IDFood { get => iDFood; set => iDFood = value; }
        public int Count { get => count; set => count = value; }
        public int Id { get => id; set => id = value; }

        public BillInfo(int id,int idBill, int idFood, int count)
        {
            this.Id = id;
            this.IDBIll = idBill;
            this.IDFood = idFood;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IDBIll = (int)row["idBill"];
            this.IDFood = (int)row["idFood"];
            this.Count = (int)row["count"];
        }
    }
}
