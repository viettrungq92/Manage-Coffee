namespace QuanLyQuanCafe
{
    partial class fAdmin
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
            tcAdmin = new TabControl();
            tpBill = new TabPage();
            panel11 = new Panel();
            btnViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            dtgvBill = new DataGridView();
            tpFood = new TabPage();
            panel6 = new Panel();
            txtSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel5 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            txbFoodName = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            txbFoodID = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            panel3 = new Panel();
            dtgvFood = new DataGridView();
            tbFoodCategory = new TabPage();
            panel1 = new Panel();
            panel13 = new Panel();
            textBox1 = new TextBox();
            label7 = new Label();
            panel14 = new Panel();
            txbCategoryID = new TextBox();
            label8 = new Label();
            panel15 = new Panel();
            btnShowCategory = new Button();
            btnEditCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            dtgkCategory = new DataGridView();
            tpTable = new TabPage();
            panel2 = new Panel();
            panel18 = new Panel();
            cbTableStatus = new ComboBox();
            label9 = new Label();
            panel12 = new Panel();
            txbTableName = new TextBox();
            label5 = new Label();
            panel16 = new Panel();
            textBox3 = new TextBox();
            label6 = new Label();
            panel17 = new Panel();
            btnShowTable = new Button();
            btnEditTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            dtgkTable = new DataGridView();
            tpAccout = new TabPage();
            panel19 = new Panel();
            btnResetPassword = new Button();
            panel21 = new Panel();
            cbAccoutType = new ComboBox();
            label11 = new Label();
            panel22 = new Panel();
            txbDisplayName = new TextBox();
            label12 = new Label();
            panel23 = new Panel();
            textBox4 = new TextBox();
            label13 = new Label();
            dtgvAccout = new DataGridView();
            panel24 = new Panel();
            btnShowAccout = new Button();
            btnEditAccout = new Button();
            btnDeleteAccout = new Button();
            btnAddAccout = new Button();
            panel20 = new Panel();
            tcAdmin.SuspendLayout();
            tpBill.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            tbFoodCategory.SuspendLayout();
            panel1.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgkCategory).BeginInit();
            tpTable.SuspendLayout();
            panel2.SuspendLayout();
            panel18.SuspendLayout();
            panel12.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgkTable).BeginInit();
            tpAccout.SuspendLayout();
            panel19.SuspendLayout();
            panel21.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccout).BeginInit();
            panel24.SuspendLayout();
            panel20.SuspendLayout();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tbFoodCategory);
            tcAdmin.Controls.Add(tpTable);
            tcAdmin.Controls.Add(tpAccout);
            tcAdmin.Location = new Point(12, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(820, 472);
            tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel11);
            tpBill.Controls.Add(dtgvBill);
            tpBill.Location = new Point(4, 34);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(812, 434);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnViewBill);
            panel11.Controls.Add(dtpkToDate);
            panel11.Controls.Add(dtpkFromDate);
            panel11.Location = new Point(6, 6);
            panel11.Name = "panel11";
            panel11.Size = new Size(755, 39);
            panel11.TabIndex = 3;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(319, 3);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(112, 34);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = true;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(446, 3);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(300, 31);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(300, 31);
            dtpkFromDate.TabIndex = 0;
            // 
            // dtgvBill
            // 
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(6, 66);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 62;
            dtgvBill.RowTemplate.Height = 33;
            dtgvBill.Size = new Size(749, 362);
            dtgvBill.TabIndex = 2;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 34);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(812, 434);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thức ăn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtSearchFoodName);
            panel6.Controls.Add(btnSearchFood);
            panel6.Location = new Point(476, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(337, 61);
            panel6.TabIndex = 0;
            // 
            // txtSearchFoodName
            // 
            txtSearchFoodName.Location = new Point(3, 14);
            txtSearchFoodName.Name = "txtSearchFoodName";
            txtSearchFoodName.Size = new Size(196, 31);
            txtSearchFoodName.TabIndex = 0;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(205, 0);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(112, 58);
            btnSearchFood.TabIndex = 4;
            btnSearchFood.Text = "Tìm";
            btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(476, 73);
            panel5.Name = "panel5";
            panel5.Size = new Size(333, 355);
            panel5.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(0, 222);
            panel10.Name = "panel10";
            panel10.Size = new Size(327, 67);
            panel10.TabIndex = 3;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(133, 20);
            nmFoodPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(180, 31);
            nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 22);
            label4.Name = "label4";
            label4.Size = new Size(59, 29);
            label4.TabIndex = 0;
            label4.Text = "Giá:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 149);
            panel9.Name = "panel9";
            panel9.Size = new Size(327, 67);
            panel9.TabIndex = 3;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(132, 18);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(192, 33);
            cbCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 22);
            label3.Name = "label3";
            label3.Size = new Size(136, 29);
            label3.TabIndex = 0;
            label3.Text = "Danh mục:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(3, 76);
            panel8.Name = "panel8";
            panel8.Size = new Size(327, 67);
            panel8.TabIndex = 2;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(130, 20);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(194, 31);
            txbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 22);
            label2.Name = "label2";
            label2.Size = new Size(121, 29);
            label2.TabIndex = 0;
            label2.Text = "Tên món:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbFoodID);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(326, 67);
            panel7.TabIndex = 1;
            // 
            // txbFoodID
            // 
            txbFoodID.Location = new Point(53, 20);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(270, 31);
            txbFoodID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 22);
            label1.Name = "label1";
            label1.Size = new Size(44, 29);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnShowFood);
            panel4.Controls.Add(btnEditFood);
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Location = new Point(4, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(466, 61);
            panel4.TabIndex = 1;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(354, 0);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(112, 58);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(236, 0);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(112, 58);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(118, 0);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(112, 58);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Xoá";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(0, 0);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(112, 58);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvFood);
            panel3.Location = new Point(6, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(464, 355);
            panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(0, 0);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 62;
            dtgvFood.RowTemplate.Height = 33;
            dtgvFood.Size = new Size(464, 352);
            dtgvFood.TabIndex = 0;
            // 
            // tbFoodCategory
            // 
            tbFoodCategory.Controls.Add(panel1);
            tbFoodCategory.Controls.Add(panel15);
            tbFoodCategory.Controls.Add(dtgkCategory);
            tbFoodCategory.Location = new Point(4, 34);
            tbFoodCategory.Name = "tbFoodCategory";
            tbFoodCategory.Padding = new Padding(3);
            tbFoodCategory.Size = new Size(812, 434);
            tbFoodCategory.TabIndex = 2;
            tbFoodCategory.Text = "Danh mục";
            tbFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel13);
            panel1.Controls.Add(panel14);
            panel1.Location = new Point(478, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 355);
            panel1.TabIndex = 5;
            // 
            // panel13
            // 
            panel13.Controls.Add(textBox1);
            panel13.Controls.Add(label7);
            panel13.Location = new Point(3, 76);
            panel13.Name = "panel13";
            panel13.Size = new Size(327, 67);
            panel13.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 31);
            textBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 22);
            label7.Name = "label7";
            label7.Size = new Size(184, 29);
            label7.TabIndex = 0;
            label7.Text = "Tên danh mục:";
            // 
            // panel14
            // 
            panel14.Controls.Add(txbCategoryID);
            panel14.Controls.Add(label8);
            panel14.Location = new Point(4, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(326, 67);
            panel14.TabIndex = 1;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(53, 20);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(270, 31);
            txbCategoryID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 22);
            label8.Name = "label8";
            label8.Size = new Size(44, 29);
            label8.TabIndex = 0;
            label8.Text = "ID:";
            // 
            // panel15
            // 
            panel15.Controls.Add(btnShowCategory);
            panel15.Controls.Add(btnEditCategory);
            panel15.Controls.Add(btnDeleteCategory);
            panel15.Controls.Add(btnAddCategory);
            panel15.Location = new Point(6, 9);
            panel15.Name = "panel15";
            panel15.Size = new Size(466, 61);
            panel15.TabIndex = 4;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(354, 0);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(112, 58);
            btnShowCategory.TabIndex = 3;
            btnShowCategory.Text = "Xem";
            btnShowCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(236, 0);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(112, 58);
            btnEditCategory.TabIndex = 2;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(118, 0);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(112, 58);
            btnDeleteCategory.TabIndex = 1;
            btnDeleteCategory.Text = "Xoá";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(0, 0);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(112, 58);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // dtgkCategory
            // 
            dtgkCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgkCategory.Location = new Point(6, 76);
            dtgkCategory.Name = "dtgkCategory";
            dtgkCategory.RowHeadersWidth = 62;
            dtgkCategory.RowTemplate.Height = 33;
            dtgkCategory.Size = new Size(464, 352);
            dtgkCategory.TabIndex = 3;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel2);
            tpTable.Controls.Add(panel17);
            tpTable.Controls.Add(dtgkTable);
            tpTable.Location = new Point(4, 34);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(812, 434);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel18);
            panel2.Controls.Add(panel12);
            panel2.Controls.Add(panel16);
            panel2.Location = new Point(476, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(333, 355);
            panel2.TabIndex = 8;
            // 
            // panel18
            // 
            panel18.Controls.Add(cbTableStatus);
            panel18.Controls.Add(label9);
            panel18.Location = new Point(3, 149);
            panel18.Name = "panel18";
            panel18.Size = new Size(327, 67);
            panel18.TabIndex = 3;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(142, 18);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(182, 33);
            cbTableStatus.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 22);
            label9.Name = "label9";
            label9.Size = new Size(136, 29);
            label9.TabIndex = 0;
            label9.Text = "Trạng thái:";
            // 
            // panel12
            // 
            panel12.Controls.Add(txbTableName);
            panel12.Controls.Add(label5);
            panel12.Location = new Point(3, 76);
            panel12.Name = "panel12";
            panel12.Size = new Size(327, 67);
            panel12.TabIndex = 2;
            // 
            // txbTableName
            // 
            txbTableName.Location = new Point(142, 20);
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(182, 31);
            txbTableName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 22);
            label5.Name = "label5";
            label5.Size = new Size(113, 29);
            label5.TabIndex = 0;
            label5.Text = "Tên bàn:";
            // 
            // panel16
            // 
            panel16.Controls.Add(textBox3);
            panel16.Controls.Add(label6);
            panel16.Location = new Point(4, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(326, 67);
            panel16.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 20);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(182, 31);
            textBox3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 22);
            label6.Name = "label6";
            label6.Size = new Size(44, 29);
            label6.TabIndex = 0;
            label6.Text = "ID:";
            // 
            // panel17
            // 
            panel17.Controls.Add(btnShowTable);
            panel17.Controls.Add(btnEditTable);
            panel17.Controls.Add(btnDeleteTable);
            panel17.Controls.Add(btnAddTable);
            panel17.Location = new Point(4, 6);
            panel17.Name = "panel17";
            panel17.Size = new Size(466, 61);
            panel17.TabIndex = 7;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(354, 0);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(112, 58);
            btnShowTable.TabIndex = 3;
            btnShowTable.Text = "Xem";
            btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(236, 0);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(112, 58);
            btnEditTable.TabIndex = 2;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(118, 0);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(112, 58);
            btnDeleteTable.TabIndex = 1;
            btnDeleteTable.Text = "Xoá";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(0, 0);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(112, 58);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // dtgkTable
            // 
            dtgkTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgkTable.Location = new Point(4, 73);
            dtgkTable.Name = "dtgkTable";
            dtgkTable.RowHeadersWidth = 62;
            dtgkTable.RowTemplate.Height = 33;
            dtgkTable.Size = new Size(464, 352);
            dtgkTable.TabIndex = 6;
            // 
            // tpAccout
            // 
            tpAccout.Controls.Add(panel20);
            tpAccout.Controls.Add(panel19);
            tpAccout.Controls.Add(panel24);
            tpAccout.Location = new Point(4, 34);
            tpAccout.Name = "tpAccout";
            tpAccout.Padding = new Padding(3);
            tpAccout.Size = new Size(812, 434);
            tpAccout.TabIndex = 4;
            tpAccout.Text = "Tài khoản";
            tpAccout.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            panel19.Controls.Add(btnResetPassword);
            panel19.Controls.Add(panel21);
            panel19.Controls.Add(panel22);
            panel19.Controls.Add(panel23);
            panel19.Location = new Point(482, 79);
            panel19.Name = "panel19";
            panel19.Size = new Size(333, 355);
            panel19.TabIndex = 5;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(209, 222);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(112, 58);
            btnResetPassword.TabIndex = 4;
            btnResetPassword.Text = "Đặt lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            panel21.Controls.Add(cbAccoutType);
            panel21.Controls.Add(label11);
            panel21.Location = new Point(3, 149);
            panel21.Name = "panel21";
            panel21.Size = new Size(327, 67);
            panel21.TabIndex = 3;
            // 
            // cbAccoutType
            // 
            cbAccoutType.FormattingEnabled = true;
            cbAccoutType.Location = new Point(186, 18);
            cbAccoutType.Name = "cbAccoutType";
            cbAccoutType.Size = new Size(138, 33);
            cbAccoutType.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 22);
            label11.Name = "label11";
            label11.Size = new Size(183, 29);
            label11.TabIndex = 0;
            label11.Text = "Loại tài khoản:";
            // 
            // panel22
            // 
            panel22.Controls.Add(txbDisplayName);
            panel22.Controls.Add(label12);
            panel22.Location = new Point(3, 76);
            panel22.Name = "panel22";
            panel22.Size = new Size(327, 67);
            panel22.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(186, 20);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(138, 31);
            txbDisplayName.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 22);
            label12.Name = "label12";
            label12.Size = new Size(157, 29);
            label12.TabIndex = 0;
            label12.Text = "Tên hiển thị:";
            // 
            // panel23
            // 
            panel23.Controls.Add(textBox4);
            panel23.Controls.Add(label13);
            panel23.Location = new Point(4, 3);
            panel23.Name = "panel23";
            panel23.Size = new Size(326, 67);
            panel23.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(185, 20);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(138, 31);
            textBox4.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(3, 22);
            label13.Name = "label13";
            label13.Size = new Size(176, 29);
            label13.TabIndex = 0;
            label13.Text = "Tên tài khoản:";
            // 
            // dtgvAccout
            // 
            dtgvAccout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccout.Location = new Point(3, 0);
            dtgvAccout.Name = "dtgvAccout";
            dtgvAccout.RowHeadersWidth = 62;
            dtgvAccout.RowTemplate.Height = 33;
            dtgvAccout.Size = new Size(464, 352);
            dtgvAccout.TabIndex = 3;
            // 
            // panel24
            // 
            panel24.Controls.Add(btnShowAccout);
            panel24.Controls.Add(btnEditAccout);
            panel24.Controls.Add(btnDeleteAccout);
            panel24.Controls.Add(btnAddAccout);
            panel24.Location = new Point(10, 12);
            panel24.Name = "panel24";
            panel24.Size = new Size(466, 61);
            panel24.TabIndex = 4;
            // 
            // btnShowAccout
            // 
            btnShowAccout.Location = new Point(354, 0);
            btnShowAccout.Name = "btnShowAccout";
            btnShowAccout.Size = new Size(112, 58);
            btnShowAccout.TabIndex = 3;
            btnShowAccout.Text = "Xem";
            btnShowAccout.UseVisualStyleBackColor = true;
            // 
            // btnEditAccout
            // 
            btnEditAccout.Location = new Point(236, 0);
            btnEditAccout.Name = "btnEditAccout";
            btnEditAccout.Size = new Size(112, 58);
            btnEditAccout.TabIndex = 2;
            btnEditAccout.Text = "Sửa";
            btnEditAccout.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccout
            // 
            btnDeleteAccout.Location = new Point(118, 0);
            btnDeleteAccout.Name = "btnDeleteAccout";
            btnDeleteAccout.Size = new Size(112, 58);
            btnDeleteAccout.TabIndex = 1;
            btnDeleteAccout.Text = "Xoá";
            btnDeleteAccout.UseVisualStyleBackColor = true;
            // 
            // btnAddAccout
            // 
            btnAddAccout.Location = new Point(0, 0);
            btnAddAccout.Name = "btnAddAccout";
            btnAddAccout.Size = new Size(112, 58);
            btnAddAccout.TabIndex = 0;
            btnAddAccout.Text = "Thêm";
            btnAddAccout.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            panel20.Controls.Add(dtgvAccout);
            panel20.Location = new Point(6, 76);
            panel20.Name = "panel20";
            panel20.Size = new Size(470, 352);
            panel20.TabIndex = 4;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 496);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tcAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            tbFoodCategory.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgkCategory).EndInit();
            tpTable.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgkTable).EndInit();
            tpAccout.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccout).EndInit();
            panel24.ResumeLayout(false);
            panel20.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private TabPage tpFood;
        private Panel panel6;
        private TextBox txtSearchFoodName;
        private Button btnSearchFood;
        private Panel panel5;
        private Panel panel4;
        private Button btnShowFood;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private Panel panel3;
        private DataGridView dtgvFood;
        private TabPage tbFoodCategory;
        private TabPage tpTable;
        private TabPage tpAccout;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label2;
        private Panel panel7;
        private TextBox txbFoodID;
        private Label label1;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private Panel panel9;
        private ComboBox cbCategory;
        private Label label3;
        private Panel panel11;
        private Button btnViewBill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private DataGridView dtgvBill;
        private Panel panel1;
        private Panel panel13;
        private TextBox textBox1;
        private Label label7;
        private Panel panel14;
        private TextBox txbCategoryID;
        private Label label8;
        private Panel panel15;
        private Button btnShowCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private DataGridView dtgkCategory;
        private Panel panel2;
        private Panel panel18;
        private ComboBox cbTableStatus;
        private Label label9;
        private Panel panel12;
        private TextBox txbTableName;
        private Label label5;
        private Panel panel16;
        private TextBox textBox3;
        private Label label6;
        private Panel panel17;
        private Button btnShowTable;
        private Button btnEditTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private DataGridView dtgkTable;
        private Panel panel19;
        private Button btnResetPassword;
        private Panel panel21;
        private ComboBox cbAccoutType;
        private Label label11;
        private Panel panel22;
        private TextBox txbDisplayName;
        private Label label12;
        private Panel panel23;
        private TextBox textBox4;
        private Label label13;
        private DataGridView dtgvAccout;
        private Panel panel24;
        private Button btnShowAccout;
        private Button btnEditAccout;
        private Button btnDeleteAccout;
        private Button btnAddAccout;
        private Panel panel20;
    }
}