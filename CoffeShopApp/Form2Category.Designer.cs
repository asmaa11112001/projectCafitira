namespace CoffeShopApp
{
    partial class Form2Category
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
            txCategoryid = new TextBox();
            txbCatName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAddCategory = new Button();
            SuspendLayout();
            // 
            // txCategoryid
            // 
            txCategoryid.Location = new Point(150, 106);
            txCategoryid.Name = "txCategoryid";
            txCategoryid.Size = new Size(150, 31);
            txCategoryid.TabIndex = 0;
            // 
            // txbCatName
            // 
            txbCatName.Location = new Point(150, 175);
            txbCatName.Name = "txbCatName";
            txbCatName.Size = new Size(150, 31);
            txbCatName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 109);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 2;
            label1.Text = "CatId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 181);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 3;
            label2.Text = "CatName";
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.FromArgb(255, 128, 0);
            btnAddCategory.Location = new Point(290, 301);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(112, 34);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "AddCat";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // Form2Category
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbCatName);
            Controls.Add(txCategoryid);
            Name = "Form2Category";
            Text = "Form2Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txCategoryid;
        private TextBox txbCatName;
        private Label label1;
        private Label label2;
        private Button btnAddCategory;
    }
}