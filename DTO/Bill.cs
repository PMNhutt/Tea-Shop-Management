using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopManagement.DTO
{
    public class Bill
    {
        private int iD;
        //? : null-able
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private string status;

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public string Status { get => status; set => status = value; }

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, string status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            var dateCheckOuttemp = row["dateCheckOut"];
            if (dateCheckOuttemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOuttemp;
            this.Status = row["status"].ToString();
        }
    }
}
