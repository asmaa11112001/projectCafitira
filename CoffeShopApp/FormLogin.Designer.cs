namespace CoffeShopApp
{
    partial class FormLogin
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
            btnLoginUser = new Button();
            tbxpassword = new TextBox();
            txtbName = new TextBox();
            txtbId = new TextBox();
            SuspendLayout();
            // 
            // UserID
            // 
            UserID.AutoSize = true;
            UserID.Location = new Point(32, 9);
            UserID.Name = "UserID";
            UserID.Size = new Size(65, 25);
            UserID.TabIndex = 3;
            UserID.Text = "UserID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 49);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 4;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 85);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 5;
            label3.Text = "UserPass";
            // 
            // btnLoginUser
            // 
            btnLoginUser.BackColor = Color.FromArgb(255, 128, 0);
            btnLoginUser.Location = new Point(205, 214);
            btnLoginUser.Name = "btnLoginUser";
            btnLoginUser.Size = new Size(112, 34);
            btnLoginUser.TabIndex = 6;
            btnLoginUser.Text = "LoginUser";
            btnLoginUser.UseVisualStyleBackColor = false;
            btnLoginUser.Click += btnLoginUser_Click;
            // 
            // tbxpassword
            // 
            tbxpassword.Location = new Point(152, 97);
            tbxpassword.Name = "tbxpassword";
            tbxpassword.Size = new Size(150, 31);
            tbxpassword.TabIndex = 7;
            // 
            // txtbName
            // 
            txtbName.Location = new Point(152, 46);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(150, 31);
            txtbName.TabIndex = 8;
            // 
            // txtbId
            // 
            txtbId.Location = new Point(152, 3);
            txtbId.Name = "txtbId";
            txtbId.Size = new Size(150, 31);
            txtbId.TabIndex = 9;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(txtbId);
            Controls.Add(txtbName);
            Controls.Add(tbxpassword);
            Controls.Add(btnLoginUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UserID);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserID;
        private Label label2;
        private Label label3;
        private Button btnLoginUser;
        private TextBox tbxpassword;
        private TextBox txtbName;
        private TextBox txtbId;
    }
}