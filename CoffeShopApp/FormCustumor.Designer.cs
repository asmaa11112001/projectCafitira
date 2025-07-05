namespace CoffeShopApp
{
    partial class FormCustumor
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
            dgvshowallproduct = new DataGridView();
            dgvSelectproduct = new DataGridView();
            txbtotalprice = new TextBox();
            label1 = new Label();
            boxnumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvshowallproduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSelectproduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxnumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // dgvshowallproduct
            // 
            dgvshowallproduct.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvshowallproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvshowallproduct.Location = new Point(0, 0);
            dgvshowallproduct.Name = "dgvshowallproduct";
            dgvshowallproduct.RowHeadersWidth = 62;
            dgvshowallproduct.Size = new Size(360, 225);
            dgvshowallproduct.TabIndex = 0;
            dgvshowallproduct.CellClick += dgvshowallproduct_CellClick;
            // 
            // dgvSelectproduct
            // 
            dgvSelectproduct.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvSelectproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelectproduct.Location = new Point(0, 278);
            dgvSelectproduct.Name = "dgvSelectproduct";
            dgvSelectproduct.RowHeadersWidth = 62;
            dgvSelectproduct.Size = new Size(360, 225);
            dgvSelectproduct.TabIndex = 1;
            dgvSelectproduct.CellContentClick += dgvSelectproduct_CellClick;
            // 
            // txbtotalprice
            // 
            txbtotalprice.BackColor = Color.White;
            txbtotalprice.Location = new Point(153, 549);
            txbtotalprice.Name = "txbtotalprice";
            txbtotalprice.Size = new Size(207, 31);
            txbtotalprice.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(31, 549);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 3;
            label1.Text = "total Price";
            // 
            // boxnumericUpDown
            // 
            boxnumericUpDown.BackColor = SystemColors.Info;
            boxnumericUpDown.Location = new Point(451, 194);
            boxnumericUpDown.Name = "boxnumericUpDown";
            boxnumericUpDown.Size = new Size(203, 31);
            boxnumericUpDown.TabIndex = 4;
            boxnumericUpDown.ValueChanged += boxnumericUpDown_ValueChanged;
            // 
            // FormCustumor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 664);
            Controls.Add(boxnumericUpDown);
            Controls.Add(label1);
            Controls.Add(txbtotalprice);
            Controls.Add(dgvSelectproduct);
            Controls.Add(dgvshowallproduct);
            Name = "FormCustumor";
            Text = "FormCustumor";
            Load += FormCustumor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvshowallproduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSelectproduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxnumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvshowallproduct;
        private DataGridView dgvSelectproduct;
        private TextBox txbtotalprice;
        private Label label1;
        private NumericUpDown boxnumericUpDown;
    }
}