using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaShopManagement.DAO;

namespace TeaShopManagement
{
    public partial class Admin : Form
    {
        public int id = 0;
        public Admin()
        {
            InitializeComponent();
            LoadListBill(dtpStart.Value, dtpEnd.Value);
            SetDateTimePicker();
        }

        void SetDateTimePicker()
        {
            DateTime today = DateTime.Now;
            //set begin of the month
            dtpStart.Value = new DateTime(today.Year, today.Month, 1);
            //set end day of the month
            dtpEnd.Value = dtpStart.Value.AddMonths(1).AddDays(-1);
        }

        void LoadListBill(DateTime checkIn, DateTime checkOut)
        {
            dgvShowBill.DataSource = BillDAO.Instance.GetListBillInfo(checkIn, checkOut);

        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            LoadListBill(dtpStart.Value, dtpEnd.Value);
        }

        private void dgvShowBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         //   int firstRowIndex = dgvShowBill.SelectedRows.Count;
            id = int.Parse(dgvShowBill.Rows[e.RowIndex].Cells[0].Value.ToString().Remove(0,5));
            BillInfoView f = new BillInfoView(id + 1);
            f.ShowDialog();
        }
    }
}
