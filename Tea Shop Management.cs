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
    public partial class Tea_Shop_Management : Form
    {    
        public Account accountInfo { get; set; }
        
        public Tea_Shop_Management(Account acc)
        {
            
            InitializeComponent();
            CheckLoginAcc(acc.RoleID);
            LoadTableList();
            LoadCategory();
            LoadWelcomeUser(acc.AccountName);
        }

        

        #region Methods

        void LoadWelcomeUser(string name)
        {
            lbWelcome.Text = "Welcome " + "'"+name+"'";
        }
        void CheckLoginAcc(int role)
        {
            try
            {
                if (role != 1)
                {
                    adminToolStripMenuItem.Visible = false;
                }
                else
                {
                    adminToolStripMenuItem.Visible = true;
                }
            }
            catch
            {

            }
            
            
        }
        void LoadCategory()
        {
            List<Category> list = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = list;
            //show exact name
            cbCategory.DisplayMember = "name";
        }

        void LoadFoodListByCategory(int id)
        {
            List<Food> list = FoodDAO.Instance.GetListFoodByCategoryID(id);
            cbTeavFood.DataSource = list;
            //show exact name
            cbTeavFood.DisplayMember = "name";
        }

        void LoadTableList()
        {
            flowLPanelTable.Controls.Clear();

            List<Table> list = TableDAO.Instance.LoadTable();

            foreach (Table item in list)
            {
             //   Button btn = new Button() {Width = TableDAO.tableW, Height = TableDAO.tableH };
                TableButton btn = new TableButton() { Width = TableDAO.tableW, Height = TableDAO.tableH };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                //set events load data when clicked
                btn.Click += Btn_Click;
                btn.DoubleClick += Btn_DoubleClick;
                
                //save table to btn
                btn.Tag = item;
                

                if (item.Status.Equals("Empty")){
                    btn.BackColor = Color.MistyRose;
                }
                else
                {
                    btn.BackColor = Color.Tomato;
                }
                flowLPanelTable.Controls.Add(btn);
            }
        }

        

        void ShowBill(int id)
        {
            //clear de khong bi chong` chat'
            listBill.Items.Clear();

            float totalP = 0;
            List<Menu> list = MenuDAO.Instance.GetListMenuByTable(id);
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
              txBTotalPrice.Text = totalP.ToString("c",culture);
            
           
        }

        void ChangeTableStatus (int id)
        {
            if (MessageBox.Show($"Change table {id - 1} status to 'Empty'?", "Tea Shop Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.UpdateTableStatus(id);
            }
        }

        #endregion
        #region Events
        private void Btn_DoubleClick(object sender, EventArgs e)
        {
            //use tag
            int tableID = ((sender as Button).Tag as Table).ID;
            ChangeTableStatus(tableID);
            LoadTableList();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            //use tag
            int tableID = ((sender as Button).Tag as Table).ID;
            //save listBill tag
            listBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountInfo f = new AccountInfo(accountInfo);
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.ShowDialog();
        }

        private void listBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategory(id);
        }

        //khi chọn table nào thì table đó sẽ có 1 cái bảng listview,
        //v thì giờ sẽ lấy cái tag của listview đó để biết đc là mình đang chọn bàn nào
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //lấy bàn dựa trên tag của listBIll đang chọn
            Table table = listBill.Tag as Table;

            int idBill = BillDAO.Instance.Get_UnPaid_Bill_ID_By_TableID(table.ID);
            //lấy idFood từ combobox
            int idFood = (cbTeavFood.SelectedItem as Food).ID;
            //lấy value từ numbericUpDown
            int count = (int)numericUpDown1.Value;

            //nếu bàn đó chưa có bill thì new bill + bill info
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMAxIDBill(), idFood, count);
            }
            //bàn đó đã có bill rồi: + bill info (alter sql)
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
            }
            TableDAO.Instance.UpdateTableStatusToBusy(table.ID);
            //load lại dữ liệu sau khi add bill này nọ
            ShowBill(table.ID);
            LoadTableList();
        }

        private void cbTeavFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            //lấy bàn dựa trên tag của listBIll đang chọn
            Table table = listBill.Tag as Table;

            int idBill = BillDAO.Instance.Get_UnPaid_Bill_ID_By_TableID(table.ID);
            //lấy idFood từ combobox
            int idFood = (cbTeavFood.SelectedItem as Food).ID;
            //lấy value từ numbericUpDown
            int count = (int)numericUpDown1.Value;

            if(idBill == -1)
            {
                MessageBox.Show("Bill empty!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BillInfoDAO.Instance.DeleteBillInfo(idBill,idFood,count);
            }
            ShowBill(table.ID);
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            //lấy bàn dựa trên tag của listBIll đang chọn
            Table table = listBill.Tag as Table;
            int idBill = BillDAO.Instance.Get_UnPaid_Bill_ID_By_TableID(table.ID);
            //  double totalPrice = Convert.ToDouble(txBTotalPrice.Text.Split('₫')[0]);
            float totalPrice = float.Parse(txBTotalPrice.Text, NumberStyles.Currency, new CultureInfo("vi-VN"));
            if (idBill != -1)
            {
                if(MessageBox.Show("Check out bill for: " + table.Name, "Tea Shop Management",MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    TableDAO.Instance.UpdateTableStatus(table.ID);
                    BillDAO.Instance.CheckOutBill(idBill, (float)totalPrice);
                    ShowBill(table.ID);
                    LoadTableList();
                }
            }

        }

        private void Tea_Shop_Management_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void flowLPanelTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
