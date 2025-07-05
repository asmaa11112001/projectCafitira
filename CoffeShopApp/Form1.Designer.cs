namespace CoffeShopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddproduct = new Button();
            btnUpdateproduct = new Button();
            btnDeleteProduct = new Button();
            btnloadproduct = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbproductId = new TextBox();
            txtbProductN = new TextBox();
            txbProductPrice = new TextBox();
            dgvProducts = new DataGridView();
            cmbcategory = new ComboBox();
            btnopenCategory = new Button();
            btnUsers = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // btnAddproduct
            // 
            btnAddproduct.BackColor = Color.FromArgb(255, 128, 0);
            btnAddproduct.Location = new Point(30, 80);
            btnAddproduct.Name = "btnAddproduct";
            btnAddproduct.Size = new Size(141, 34);
            btnAddproduct.TabIndex = 0;
            btnAddproduct.Text = "AddProduct";
            btnAddproduct.UseVisualStyleBackColor = false;
            btnAddproduct.Click += btnAddproduct_Click;
            // 
            // btnUpdateproduct
            // 
            btnUpdateproduct.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateproduct.Location = new Point(30, 171);
            btnUpdateproduct.Name = "btnUpdateproduct";
            btnUpdateproduct.Size = new Size(141, 34);
            btnUpdateproduct.TabIndex = 1;
            btnUpdateproduct.Text = "UpdateProduct";
            btnUpdateproduct.UseVisualStyleBackColor = false;
            btnUpdateproduct.Click += btnUpdateproduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteProduct.Location = new Point(30, 260);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(141, 34);
            btnDeleteProduct.TabIndex = 2;
            btnDeleteProduct.Text = "deleteProduct";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnloadproduct
            // 
            btnloadproduct.BackColor = Color.FromArgb(255, 128, 0);
            btnloadproduct.Location = new Point(30, 370);
            btnloadproduct.Name = "btnloadproduct";
            btnloadproduct.Size = new Size(141, 34);
            btnloadproduct.TabIndex = 3;
            btnloadproduct.Text = "Load";
            btnloadproduct.UseVisualStyleBackColor = false;
            btnloadproduct.Click += btnloadproduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(562, 157);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 4;
            label1.Text = "productId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(562, 216);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 5;
            label2.Text = "productNme";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 269);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 6;
            label3.Text = "price";
            // 
            // txbproductId
            // 
            txbproductId.Location = new Point(681, 157);
            txbproductId.Name = "txbproductId";
            txbproductId.Size = new Size(150, 31);
            txbproductId.TabIndex = 7;
            // 
            // txtbProductN
            // 
            txtbProductN.Location = new Point(681, 213);
            txtbProductN.Name = "txtbProductN";
            txtbProductN.Size = new Size(150, 31);
            txtbProductN.TabIndex = 8;
            // 
            // txbProductPrice
            // 
            txbProductPrice.Location = new Point(681, 263);
            txbProductPrice.Name = "txbProductPrice";
            txbProductPrice.Size = new Size(150, 31);
            txbProductPrice.TabIndex = 9;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = Color.FromArgb(255, 192, 128);
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(30, 447);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(360, 225);
            dgvProducts.TabIndex = 10;
            dgvProducts.CellContentClick += dgvProducts_CellClick;
            // 
            // cmbcategory
            // 
            cmbcategory.FormattingEnabled = true;
            cmbcategory.Location = new Point(665, 340);
            cmbcategory.Name = "cmbcategory";
            cmbcategory.Size = new Size(182, 33);
            cmbcategory.TabIndex = 11;
            // 
            // btnopenCategory
            // 
            btnopenCategory.BackColor = Color.RosyBrown;
            btnopenCategory.Location = new Point(591, 638);
            btnopenCategory.Name = "btnopenCategory";
            btnopenCategory.Size = new Size(112, 34);
            btnopenCategory.TabIndex = 12;
            btnopenCategory.Text = "openCategory";
            btnopenCategory.UseVisualStyleBackColor = false;
            btnopenCategory.Click += btnopenCategory_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(192, 255, 255);
            btnUsers.Location = new Point(735, 638);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(112, 34);
            btnUsers.TabIndex = 14;
            btnUsers.Text = "openUsers";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1261, 806);
            Controls.Add(btnUsers);
            Controls.Add(btnopenCategory);
            Controls.Add(cmbcategory);
            Controls.Add(dgvProducts);
            Controls.Add(txbProductPrice);
            Controls.Add(txtbProductN);
            Controls.Add(txbproductId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnloadproduct);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnUpdateproduct);
            Controls.Add(btnAddproduct);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddproduct;
        private Button btnUpdateproduct;
        private Button btnDeleteProduct;
        private Button btnloadproduct;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbproductId;
        private TextBox txtbProductN;
        private TextBox txbProductPrice;
        private DataGridView dgvProducts;
        private ComboBox cmbcategory;
        private Button btnopenCategory;
        private Button btnUsers;
    }
}
