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
using System.Xml.Linq;

namespace CoffeShopApp
{
    public partial class FormUsers : Form
    {
        private readonly UserServices userService;
        public FormUsers()
        {
            InitializeComponent();
            userService = new UserServices(new Context());
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = userService.GetAll();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                UserId = int.Parse(txtId.Text),
                UserName = txtName.Text,
                Password = txtpass.Text
            };
            userService.Add(user);
            LoadUsers();
            ClearInputs();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            var user = (User)dgvUsers.CurrentRow.DataBoundItem;
            user.UserName = txtName.Text;
            user.Password =txtpass.Text;

            userService.Update(user);
            LoadUsers();
            ClearInputs();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            var user = (User)dgvUsers.CurrentRow.DataBoundItem;
            userService.Delete(user.UserId);
            LoadUsers();
            ClearInputs();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var user = (User)dgvUsers.Rows[e.RowIndex].DataBoundItem;
            txtId.Text = user.UserId.ToString();
            txtName.Text = user.UserName;
            txtpass.Text = user.Password;
        }

        private void ClearInputs()
        {
            txtId.Clear();
            txtName.Clear();
            txtpass.Clear();
        }
    }
}
