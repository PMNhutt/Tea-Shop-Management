
namespace TeaShopManagement
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Food = new System.Windows.Forms.TabControl();
            this.tcFood = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBSearchFoodName = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.numUpDFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtBoxFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBIdFood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.tcAccount = new System.Windows.Forms.TabPage();
            this.panel21 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txtBUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnUpdateAcc = new System.Windows.Forms.Button();
            this.btnRemoveAcc = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tcCategory = new System.Windows.Forms.TabPage();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtBCategoryName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtBCategoryID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tcStatistical = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dgvShowBill = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnShowBill = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.Food.SuspendLayout();
            this.tcFood.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDFoodPrice)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.tcAccount.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel20.SuspendLayout();
            this.tcCategory.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tcStatistical.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBill)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // Food
            // 
            this.Food.Controls.Add(this.tcFood);
            this.Food.Controls.Add(this.tcAccount);
            this.Food.Controls.Add(this.tcCategory);
            this.Food.Controls.Add(this.tcStatistical);
            this.Food.Location = new System.Drawing.Point(14, 12);
            this.Food.Name = "Food";
            this.Food.SelectedIndex = 0;
            this.Food.Size = new System.Drawing.Size(873, 601);
            this.Food.TabIndex = 0;
            // 
            // tcFood
            // 
            this.tcFood.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tcFood.Controls.Add(this.panel4);
            this.tcFood.Controls.Add(this.panel3);
            this.tcFood.Controls.Add(this.panel2);
            this.tcFood.Controls.Add(this.panel1);
            this.tcFood.Location = new System.Drawing.Point(4, 29);
            this.tcFood.Name = "tcFood";
            this.tcFood.Padding = new System.Windows.Forms.Padding(3);
            this.tcFood.Size = new System.Drawing.Size(865, 568);
            this.tcFood.TabIndex = 0;
            this.tcFood.Text = "Food";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtBSearchFoodName);
            this.panel4.Controls.Add(this.btnSearchFood);
            this.panel4.Location = new System.Drawing.Point(454, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(403, 68);
            this.panel4.TabIndex = 3;
            // 
            // txtBSearchFoodName
            // 
            this.txtBSearchFoodName.Location = new System.Drawing.Point(3, 21);
            this.txtBSearchFoodName.Name = "txtBSearchFoodName";
            this.txtBSearchFoodName.Size = new System.Drawing.Size(300, 28);
            this.txtBSearchFoodName.TabIndex = 2;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.BackColor = System.Drawing.Color.Tomato;
            this.btnSearchFood.Location = new System.Drawing.Point(310, 3);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(89, 62);
            this.btnSearchFood.TabIndex = 1;
            this.btnSearchFood.Text = "Search";
            this.btnSearchFood.UseVisualStyleBackColor = false;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(454, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 482);
            this.panel3.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.numUpDFoodPrice);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(0, 183);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(403, 54);
            this.panel8.TabIndex = 4;
            // 
            // numUpDFoodPrice
            // 
            this.numUpDFoodPrice.Location = new System.Drawing.Point(129, 14);
            this.numUpDFoodPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numUpDFoodPrice.Name = "numUpDFoodPrice";
            this.numUpDFoodPrice.Size = new System.Drawing.Size(260, 28);
            this.numUpDFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.cbFoodCategory);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(3, 123);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(399, 54);
            this.panel7.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(126, 13);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(259, 28);
            this.cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.txtBoxFoodName);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(3, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(399, 54);
            this.panel6.TabIndex = 2;
            // 
            // txtBoxFoodName
            // 
            this.txtBoxFoodName.Location = new System.Drawing.Point(126, 14);
            this.txtBoxFoodName.Name = "txtBoxFoodName";
            this.txtBoxFoodName.Size = new System.Drawing.Size(259, 28);
            this.txtBoxFoodName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.txtBIdFood);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 54);
            this.panel5.TabIndex = 1;
            // 
            // txtBIdFood
            // 
            this.txtBIdFood.Enabled = false;
            this.txtBIdFood.Location = new System.Drawing.Point(126, 14);
            this.txtBIdFood.Name = "txtBIdFood";
            this.txtBIdFood.ReadOnly = true;
            this.txtBIdFood.Size = new System.Drawing.Size(259, 28);
            this.txtBIdFood.TabIndex = 1;
            this.txtBIdFood.TextChanged += new System.EventHandler(this.txtBIdFood_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.btnUpdateFood);
            this.panel2.Controls.Add(this.btnDeleteFood);
            this.panel2.Controls.Add(this.btnAddFood);
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 68);
            this.panel2.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLoad.Location = new System.Drawing.Point(290, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 62);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.BackColor = System.Drawing.Color.BurlyWood;
            this.btnUpdateFood.Location = new System.Drawing.Point(195, 3);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(89, 62);
            this.btnUpdateFood.TabIndex = 2;
            this.btnUpdateFood.Text = "Update";
            this.btnUpdateFood.UseVisualStyleBackColor = false;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDeleteFood.Location = new System.Drawing.Point(99, 3);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(89, 62);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Remove";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddFood.Location = new System.Drawing.Point(3, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(89, 62);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Add";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFood);
            this.panel1.Location = new System.Drawing.Point(7, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 482);
            this.panel1.TabIndex = 0;
            // 
            // dgvFood
            // 
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(3, 3);
            this.dgvFood.MultiSelect = false;
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 29;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(434, 476);
            this.dgvFood.TabIndex = 0;
            // 
            // tcAccount
            // 
            this.tcAccount.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tcAccount.Controls.Add(this.panel21);
            this.tcAccount.Controls.Add(this.panel11);
            this.tcAccount.Controls.Add(this.panel20);
            this.tcAccount.Location = new System.Drawing.Point(4, 29);
            this.tcAccount.Name = "tcAccount";
            this.tcAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tcAccount.Size = new System.Drawing.Size(865, 568);
            this.tcAccount.TabIndex = 1;
            this.tcAccount.Text = "Account";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.dgvAccount);
            this.panel21.Location = new System.Drawing.Point(7, 80);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(438, 482);
            this.panel21.TabIndex = 8;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 29;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(434, 476);
            this.dgvAccount.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel19);
            this.panel11.Controls.Add(this.panel17);
            this.panel11.Controls.Add(this.panel18);
            this.panel11.Location = new System.Drawing.Point(454, 80);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(403, 482);
            this.panel11.TabIndex = 6;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Transparent;
            this.panel19.Controls.Add(this.txtDisplayName);
            this.panel19.Controls.Add(this.label10);
            this.panel19.Location = new System.Drawing.Point(3, 62);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(399, 54);
            this.panel19.TabIndex = 4;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(152, 14);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(233, 28);
            this.txtDisplayName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Display Name:";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Controls.Add(this.cbRoles);
            this.panel17.Controls.Add(this.label6);
            this.panel17.Location = new System.Drawing.Point(3, 122);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(399, 54);
            this.panel17.TabIndex = 3;
            // 
            // cbRoles
            // 
            this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(152, 13);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(233, 28);
            this.cbRoles.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Role:";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Transparent;
            this.panel18.Controls.Add(this.txtBUserName);
            this.panel18.Controls.Add(this.label9);
            this.panel18.Location = new System.Drawing.Point(3, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(399, 54);
            this.panel18.TabIndex = 2;
            // 
            // txtBUserName
            // 
            this.txtBUserName.Location = new System.Drawing.Point(152, 14);
            this.txtBUserName.Name = "txtBUserName";
            this.txtBUserName.Size = new System.Drawing.Size(233, 28);
            this.txtBUserName.TabIndex = 1;
            this.txtBUserName.TextChanged += new System.EventHandler(this.txtBUserName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "User Name:";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btnUpdateAcc);
            this.panel20.Controls.Add(this.btnRemoveAcc);
            this.panel20.Controls.Add(this.btnAddAccount);
            this.panel20.Location = new System.Drawing.Point(7, 6);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(438, 68);
            this.panel20.TabIndex = 5;
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.BackColor = System.Drawing.Color.BurlyWood;
            this.btnUpdateAcc.Location = new System.Drawing.Point(195, 3);
            this.btnUpdateAcc.Name = "btnUpdateAcc";
            this.btnUpdateAcc.Size = new System.Drawing.Size(89, 62);
            this.btnUpdateAcc.TabIndex = 2;
            this.btnUpdateAcc.Text = "Update";
            this.btnUpdateAcc.UseVisualStyleBackColor = false;
            this.btnUpdateAcc.Click += new System.EventHandler(this.btnUpdateAcc_Click);
            // 
            // btnRemoveAcc
            // 
            this.btnRemoveAcc.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRemoveAcc.Location = new System.Drawing.Point(99, 3);
            this.btnRemoveAcc.Name = "btnRemoveAcc";
            this.btnRemoveAcc.Size = new System.Drawing.Size(89, 62);
            this.btnRemoveAcc.TabIndex = 1;
            this.btnRemoveAcc.Text = "Remove";
            this.btnRemoveAcc.UseVisualStyleBackColor = false;
            this.btnRemoveAcc.Click += new System.EventHandler(this.btnRemoveAcc_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddAccount.Location = new System.Drawing.Point(3, 3);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(89, 62);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // tcCategory
            // 
            this.tcCategory.BackColor = System.Drawing.Color.PapayaWhip;
            this.tcCategory.Controls.Add(this.panel16);
            this.tcCategory.Controls.Add(this.panel10);
            this.tcCategory.Controls.Add(this.panel15);
            this.tcCategory.Location = new System.Drawing.Point(4, 29);
            this.tcCategory.Name = "tcCategory";
            this.tcCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tcCategory.Size = new System.Drawing.Size(865, 568);
            this.tcCategory.TabIndex = 2;
            this.tcCategory.Text = "Category";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.dgvCategory);
            this.panel16.Location = new System.Drawing.Point(7, 80);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(438, 482);
            this.panel16.TabIndex = 7;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(3, 3);
            this.dgvCategory.MultiSelect = false;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 29;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(434, 476);
            this.dgvCategory.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Location = new System.Drawing.Point(454, 80);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(403, 482);
            this.panel10.TabIndex = 5;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.Controls.Add(this.txtBCategoryName);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Location = new System.Drawing.Point(3, 63);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(399, 54);
            this.panel13.TabIndex = 2;
            // 
            // txtBCategoryName
            // 
            this.txtBCategoryName.Location = new System.Drawing.Point(126, 14);
            this.txtBCategoryName.Name = "txtBCategoryName";
            this.txtBCategoryName.Size = new System.Drawing.Size(259, 28);
            this.txtBCategoryName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name:";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Controls.Add(this.txtBCategoryID);
            this.panel14.Controls.Add(this.label8);
            this.panel14.Location = new System.Drawing.Point(3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(396, 54);
            this.panel14.TabIndex = 1;
            // 
            // txtBCategoryID
            // 
            this.txtBCategoryID.Enabled = false;
            this.txtBCategoryID.Location = new System.Drawing.Point(126, 14);
            this.txtBCategoryID.Name = "txtBCategoryID";
            this.txtBCategoryID.ReadOnly = true;
            this.txtBCategoryID.Size = new System.Drawing.Size(259, 28);
            this.txtBCategoryID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnUpdateCategory);
            this.panel15.Controls.Add(this.btnRemoveCategory);
            this.panel15.Controls.Add(this.btnAddCategory);
            this.panel15.Location = new System.Drawing.Point(7, 6);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(438, 68);
            this.panel15.TabIndex = 4;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.BurlyWood;
            this.btnUpdateCategory.Location = new System.Drawing.Point(195, 3);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(89, 62);
            this.btnUpdateCategory.TabIndex = 2;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRemoveCategory.Location = new System.Drawing.Point(99, 3);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(89, 62);
            this.btnRemoveCategory.TabIndex = 1;
            this.btnRemoveCategory.Text = "Remove";
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddCategory.Location = new System.Drawing.Point(3, 3);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(89, 62);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tcStatistical
            // 
            this.tcStatistical.BackColor = System.Drawing.Color.PeachPuff;
            this.tcStatistical.Controls.Add(this.panel12);
            this.tcStatistical.Controls.Add(this.panel9);
            this.tcStatistical.Location = new System.Drawing.Point(4, 29);
            this.tcStatistical.Name = "tcStatistical";
            this.tcStatistical.Padding = new System.Windows.Forms.Padding(3);
            this.tcStatistical.Size = new System.Drawing.Size(865, 568);
            this.tcStatistical.TabIndex = 3;
            this.tcStatistical.Text = "Statistical";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dgvShowBill);
            this.panel12.Location = new System.Drawing.Point(6, 63);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(853, 499);
            this.panel12.TabIndex = 1;
            // 
            // dgvShowBill
            // 
            this.dgvShowBill.AllowUserToAddRows = false;
            this.dgvShowBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowBill.Location = new System.Drawing.Point(3, 3);
            this.dgvShowBill.MultiSelect = false;
            this.dgvShowBill.Name = "dgvShowBill";
            this.dgvShowBill.ReadOnly = true;
            this.dgvShowBill.RowHeadersWidth = 51;
            this.dgvShowBill.RowTemplate.Height = 29;
            this.dgvShowBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowBill.Size = new System.Drawing.Size(847, 493);
            this.dgvShowBill.TabIndex = 0;
            this.dgvShowBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowBill_CellDoubleClick);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnShowBill);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.dtpEnd);
            this.panel9.Controls.Add(this.dtpStart);
            this.panel9.Location = new System.Drawing.Point(6, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(853, 51);
            this.panel9.TabIndex = 0;
            // 
            // btnShowBill
            // 
            this.btnShowBill.BackColor = System.Drawing.Color.Tomato;
            this.btnShowBill.Location = new System.Drawing.Point(725, 3);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.Size = new System.Drawing.Size(94, 43);
            this.btnShowBill.TabIndex = 2;
            this.btnShowBill.Text = "Show";
            this.btnShowBill.UseVisualStyleBackColor = false;
            this.btnShowBill.Click += new System.EventHandler(this.btnShowBill_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(372, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "From";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(425, 8);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(250, 28);
            this.dtpEnd.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(84, 8);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(250, 28);
            this.dtpStart.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeaShopManagement.Properties.Resources.hand_drawn_bubble_tea_flavors_52683_46533;
            this.ClientSize = new System.Drawing.Size(900, 625);
            this.Controls.Add(this.Food);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Food.ResumeLayout(false);
            this.tcFood.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDFoodPrice)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.tcAccount.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.tcCategory.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.tcStatistical.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBill)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Food;
        private System.Windows.Forms.TabPage tcFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.TabPage tcAccount;
        private System.Windows.Forms.TabPage tcCategory;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.TextBox txtBSearchFoodName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtBIdFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtBoxFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown numUpDFoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtBCategoryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtBCategoryID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txtBUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button btnUpdateAcc;
        private System.Windows.Forms.Button btnRemoveAcc;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TabPage tcStatistical;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dgvShowBill;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnShowBill;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label10;
    }
}