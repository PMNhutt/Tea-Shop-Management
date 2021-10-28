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

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txtBoxFoodName.Text;
            int idCategory = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)numUpDFoodPrice.Value;

            int checkTableStatus = TableDAO.Instance.CheckOccupiedTable();
            if(checkTableStatus > 0)
            {
                MessageBox.Show("Can't perform when customer is in the shop!!!");
            }
            else
            {
                int checkExistFood = FoodDAO.Instance.GetFoodByName(name);
                if (checkExistFood > 0)
                {
                    MessageBox.Show("This food is already exist!", "Error");
                }
                else
                {
                    if (FoodDAO.Instance.AddFood(name, idCategory, price))
                    {
                        MessageBox.Show("Add successfully");
                        LoadListFood();
                    }
                    else
                    {
                        MessageBox.Show("Add failed!");
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
                MessageBox.Show("Can't perform when customer is in the shop!!!");
            }
            else
            {
                if (FoodDAO.Instance.UpdateFood(idFood, name, idCategory, price))
                {
                    MessageBox.Show("Update successfully");
                    LoadListFood();
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }
            }          
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {            
            int idFood = int.Parse(txtBIdFood.Text);


            int checkTableStatus = TableDAO.Instance.CheckOccupiedTable();
            if (checkTableStatus > 0)
            {
                MessageBox.Show("Can't perform when customer is in the shop!!!");
            }
            else
            {
                if (FoodDAO.Instance.DeleteFood(idFood))
                {
                    MessageBox.Show("Delete successfully");
                    LoadListFood();
                }
                else
                {
                    MessageBox.Show("Delete failed!");
                }
            }
            
        }
        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            dgvFood.DataSource = GetListSearch(txtBSearchFoodName.Text);
        }

        #endregion


    }
}
