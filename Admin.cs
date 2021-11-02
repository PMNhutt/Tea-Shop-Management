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
using TeaShopManagement.DTO;

namespace TeaShopManagement
{
    public partial class Admin : Form
    {
        public int id = 0;
        BindingSource source;
        public Admin()
        {
            InitializeComponent();
            Loads();                     
        }

        #region Methods

        List<Food> GetListSearch(string name)
        {
            List<Food> list = FoodDAO.Instance.SearchFoodByFoodName(name);
           
            return list;
        }
        void Loads()
        {
            LoadListBill(dtpStart.Value, dtpEnd.Value);
            SetDateTimePicker();
            LoadListFood();
            LoadCategoryListToComboBox(cbFoodCategory);
            LoadListAcc();
            LoadRoleAccountToComboBox(cbRoles);
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

        void LoadListFood()
        {
            var list = FoodDAO.Instance.GetListFood();

            source = new BindingSource();
            source.DataSource = list;

            txtBIdFood.DataBindings.Clear();
            txtBoxFoodName.DataBindings.Clear();
            numUpDFoodPrice.DataBindings.Clear();

            //fix change value in textbox -> also change dataBinding
            //formatingEnable = true -> auto parse type (string to int,...)
            //DataSourceUpdateMode -> default: Onvalidation
            //                     -> OnPropertyChange: change imidiately when binding
            //                     -> Never: only change 1 side (what we wanted)
            txtBIdFood.DataBindings.Add("Text", source, "id", true, DataSourceUpdateMode.Never);
            txtBoxFoodName.DataBindings.Add("Text", source, "name", true, DataSourceUpdateMode.Never);
            numUpDFoodPrice.DataBindings.Add("Value", source, "price", true, DataSourceUpdateMode.Never);

            dgvFood.DataSource = null;
            dgvFood.DataSource = source;
        }

        void LoadCategoryListToComboBox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }

        void LoadRoleAccountToComboBox(ComboBox cb)
        {
          //  int roleid = int.Parse(dgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString());
            cb.DataSource = RoleDAO.Instance.GetListRole();
            cb.DisplayMember = "roleName";
        }

        void LoadListAcc()
        {
            var list = AccountDAO.Instance.GetListAccount();

            source = new BindingSource();
            source.DataSource = list;

            txtBUserName.DataBindings.Clear();
            txtDisplayName.DataBindings.Clear();

            txtBUserName.DataBindings.Add("Text", source, "User Name", true, DataSourceUpdateMode.Never);
            txtDisplayName.DataBindings.Add("Text", source, "Display Name", true, DataSourceUpdateMode.Never);
         //   cbRoles.DataBindings.Add("Text", source, "Role ID", true, DataSourceUpdateMode.Never);
            
            dgvAccount.DataSource = null;
            dgvAccount.DataSource = source;
        }
        #endregion

        #region Events

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            LoadListBill(dtpStart.Value, dtpEnd.Value);
        }

        private void dgvShowBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        
            id = int.Parse(dgvShowBill.Rows[e.RowIndex].Cells[0].Value.ToString());
            BillInfoView f = new BillInfoView(id);
            f.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        //binding category by food id change
        private void txtBIdFood_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFood.SelectedCells.Count > 0)
                {
                    //get id category from selected row 
                    int id = (int)dgvFood.SelectedCells[0].OwningRow.Cells["IDCategory"].Value;

                    Category category = CategoryDAO.Instance.GetCategoryById(id);

                    cbFoodCategory.SelectedItem = category;

                    int index = -1;
                    int i = 0;

                    foreach (Category item in cbFoodCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbFoodCategory.SelectedIndex = index;
                }
            }
            catch
            {

            }
            
        }

        //binding role when userName changed
        private void txtBUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvAccount.SelectedCells.Count > 0)
                {
                    int id = (int)dgvAccount.SelectedCells[0].OwningRow.Cells["Role ID"].Value;
                    Role role = RoleDAO.Instance.GetRoleById(id);

                    cbRoles.SelectedItem = role;

                    int index = -1;
                    int i = 0;

                    foreach (Role item in cbRoles.Items)
                    {
                        if (item.RoleId == role.RoleId)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbRoles.SelectedIndex = index;
                }
            }
            catch
            {

            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txtBoxFoodName.Text;
            int idCategory = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)numUpDFoodPrice.Value;

            int checkTableStatus = TableDAO.Instance.CheckOccupiedTable();
            if(checkTableStatus > 0)
            {
                MessageBox.Show("Can't perform while customer is in the shop!!!","Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int checkExistFood = FoodDAO.Instance.GetFoodByName(name);
                if (checkExistFood > 0)
                {
                    MessageBox.Show("This food is already exist!", "Admin", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }
                else
                {
                    if (FoodDAO.Instance.AddFood(name, idCategory, price))
                    {
                        MessageBox.Show("Add successfully", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListFood();
                    }
                    else
                    {
                        MessageBox.Show("Add failed!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                       
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            string name = txtBoxFoodName.Text;
            int idCategory = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)numUpDFoodPrice.Value;
            int idFood = int.Parse(txtBIdFood.Text);

            int checkTableStatus = TableDAO.Instance.CheckOccupiedTable();
            if (checkTableStatus > 0)
            {
                MessageBox.Show("Can't perform while customer is in the shop!!!","Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (FoodDAO.Instance.UpdateFood(idFood, name, idCategory, price))
                {
                    MessageBox.Show("Update successfully", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListFood();
                }
                else
                {
                    MessageBox.Show("Update failed!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove this?", "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                System.Windows.Forms.DialogResult.OK)
            {
                int idFood = int.Parse(txtBIdFood.Text);


                int checkTableStatus = TableDAO.Instance.CheckOccupiedTable();
                if (checkTableStatus > 0)
                {
                    MessageBox.Show("Can't perform while customer is in the shop!!!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (FoodDAO.Instance.DeleteFood(idFood))
                    {
                        MessageBox.Show("Remove successfully", "Admin", MessageBoxButtons.OK , MessageBoxIcon.Information);
                        LoadListFood();
                    }
                    else
                    {
                        MessageBox.Show("Remove failed!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }           
           
            
        }
        private void btnSearchFood_Click(object sender, EventArgs e)
        {

            var list = GetListSearch(txtBSearchFoodName.Text);

            source = new BindingSource();
            source.DataSource = list;

            txtBIdFood.DataBindings.Clear();
            txtBoxFoodName.DataBindings.Clear();
            numUpDFoodPrice.DataBindings.Clear();

            //fix change value in textbox -> also change dataBinding
            //formatingEnable = true -> auto parse type (string to int,...)
            //DataSourceUpdateMode -> default: Onvalidation
            //                     -> OnPropertyChange: change imidiately when binding
            //                     -> Never: only change 1 side (what we wanted)
            txtBIdFood.DataBindings.Add("Text", source, "id", true, DataSourceUpdateMode.Never);
            txtBoxFoodName.DataBindings.Add("Text", source, "name", true, DataSourceUpdateMode.Never);
            numUpDFoodPrice.DataBindings.Add("Value", source, "price", true, DataSourceUpdateMode.Never);

            dgvFood.DataSource = null;
            dgvFood.DataSource = source;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            
            string accountName = txtBUserName.Text;
            string displayName = txtDisplayName.Text;
            int roleId = (cbRoles.SelectedItem as Role).RoleId;

            Account checkExistAcc = AccountDAO.Instance.GetAccByUserName(accountName);
            if (checkExistAcc != null)
            {
                //check if this acc is used to work in our shop (status = 'passive')
                if (AccountDAO.Instance.CheckAccStatusByUserName(accountName) != null)
                {
                    if (MessageBox.Show($"Account (User Name: {accountName}, Display Name: {displayName}) " +
                        $"used to work here. Recruit this one again?", "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                        System.Windows.Forms.DialogResult.OK)
                    {
                        AccountDAO.Instance.ChangeAccStatus(accountName);
                        LoadListAcc();
                    }                   
                   
                }
                else
                {
                    MessageBox.Show("This account is exist!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                if (AccountDAO.Instance.AddAccount(accountName, roleId, displayName, "123"))
                {
                    MessageBox.Show("Add successfully with default password = 123", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListAcc();
                }
                else
                {
                    MessageBox.Show("Add failed!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnRemoveAcc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove this?", "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==
                System.Windows.Forms.DialogResult.OK)
            {
                string userName = txtBUserName.Text;
              
                if (AccountDAO.Instance.RemoveAccount(userName))
                {
                    MessageBox.Show("Remove successfully", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListAcc();
                }
                else
                {
                    MessageBox.Show("Remove failed!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            string accountName = txtBUserName.Text;
            string displayName = txtDisplayName.Text;
            int roleId = (cbRoles.SelectedItem as Role).RoleId;

            if (AccountDAO.Instance.UpdateAccount(accountName, displayName, roleId))
            {
                MessageBox.Show("Update successfully", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListAcc();
            }
            else
            {
                MessageBox.Show("Update failed... [User Name] must be the same!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


    }
}
