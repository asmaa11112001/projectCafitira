namespace CoffeShopApp
{
    partial class FormUsers
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
            UserID = new Label();
            label2 = new Label();
            label3 = new Label();
            txtpass = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            btnAddUser = new Button();
            btnUpdateUser = new Button();
            btnDeleteUser = new Button();
            dgvUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // UserID
            // 
            UserID.AutoSize = true;
            UserID.BackColor = Color.FromArgb(255, 255, 192);
            UserID.Location = new Point(432, 73);
            UserID.Name = "UserID";
            UserID.Size = new Size(63, 25);
            UserID.TabIndex = 0;
            UserID.Text = "UserId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(432, 149);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(432, 217);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 2;
            label3.Text = "UserPass";
            // 
            // txtpass
            // 
            txtpass.Location = new Point(583, 211);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(150, 31);
            txtpass.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(583, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(583, 73);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 5;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(255, 128, 0);
            btnAddUser.Location = new Point(848, 258);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(112, 34);
            btnAddUser.TabIndex = 6;
            btnAddUser.Text = "AddUser";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateUser.Location = new Point(848, 337);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(112, 34);
            btnUpdateUser.TabIndex = 7;
            btnUpdateUser.Text = "UpdateUser";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteUser.Location = new Point(848, 418);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(112, 34);
            btnDeleteUser.TabIndex = 8;
            btnDeleteUser.Text = "DeleteUser";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = Color.FromArgb(255, 192, 128);
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(222, 462);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(360, 225);
            dgvUsers.TabIndex = 9;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // FormUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1252, 699);
            Controls.Add(dgvUsers);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnUpdateUser);
            Controls.Add(btnAddUser);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(txtpass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UserID);
            Name = "FormUsers";
            Text = "FormUsers";
            Load += FormUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserID;
        private Label label2;
        private Label label3;
        private TextBox txtpass;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnAddUser;
        private Button btnUpdateUser;
        private Button btnDeleteUser;
        private DataGridView dgvUsers;
    }
}