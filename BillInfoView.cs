using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaShopManagement.DAO;
using TeaShopManagement.DTO;

namespace TeaShopManagement
{
    public partial class BillInfoView : Form
    {
        

        
        public BillInfoView(int id)
        {
            InitializeComponent();
            ShowBill(id);
        }

        void ShowBill(int id)
        {
            //clear de khong bi chong` chat'
            listBill.Items.Clear();

            float totalP = 0;
            List<Menu> list = MenuDAO.Instance.GetListPaidMenuByIdBill(id);
            foreach (Menu item in list)
            {
                //list view là add vô 1 item, và những cái sau là sub item
                ListViewItem listview = new ListViewItem(item.FoodName);
                listview.SubItems.Add(item.Count.ToString());
                listview.SubItems.Add(item.Price.ToString());
                listview.SubItems.Add(item.TotalPrice.ToString());

                totalP += item.TotalPrice;

                listBill.Items.Add(listview);
            }

            //vietnamdong currency :V
            CultureInfo culture = new CultureInfo("vi-VN");
            txBTotalPrice.Text = totalP.ToString("c", culture);


        }
    }
}
