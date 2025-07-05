using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopApp
{
    public partial class FormLogin : Form
    {
        private userService userService;

        public FormLogin()
        {
            InitializeComponent();
            userService = new userService(new Context());
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //using (var context = new Context())
            //{
            //    if (!context.Users.Any())
            //    {
            //        context.Users.AddRange(new List<User>
            //{
            //    new User { UserId=1, UserName = "admin", Password = "1234", Role = "Admin" },
            //    new User { UserId=2, UserName = "user1", Password = "1111", Role = "User" }
            //});

            //        context.SaveChanges();
            //    }
            //}
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            var username = txtbName.Text;
            var password = tbxpassword.Text;

            var user = userService.Login(username, password);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.UserName} - Role: {user.Role}");

                if (user.Role == "User")
                {
                    new FormCustumor().Show();
                    this.Hide();
                }
                // new MainForm().Show(); this.Hide();
                else
                {
                    this.Hide();
                    var mainForm = new Form1();
                    mainForm.Show();
                }
            }
            else
            {
                label3.Text = "Invalid username or password";
            }
        }
    }
    }

