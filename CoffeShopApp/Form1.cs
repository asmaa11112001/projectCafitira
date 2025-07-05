using BLL;
using DAL;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
namespace CoffeShopApp
{
    public partial class Form1 : Form
    {
        private readonly ProductServices productService;
        private readonly CategoryServices categoryService;
        private readonly Context context;
        public Form1()
        {
            InitializeComponent();
            context = new Context();
            productService = new ProductServices(context);
            categoryService = new CategoryServices(context);
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = context.Cateigorys.ToList();
            cmbcategory.DataSource = categories;
            cmbcategory.DisplayMember = "CatigoryName";
            cmbcategory.ValueMember = "CatigoryId";
        }
        private void ClearProductFields()
        {
            txbproductId.Clear();
            txtbProductN.Clear();
            txbProductPrice.Clear();
            cmbcategory.SelectedIndex = -1; //
        }
        private void btnloadproduct_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = productService.GetAll()
               .Select(p => new
               {
                   p.ProductId,
                   p.ProductName,
                   p.Price,
                   Category = p.Catigory.CatigoryName
               }).ToList();
        }

        private void btnAddproduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbproductId.Text) ||
                string.IsNullOrWhiteSpace(txtbProductN.Text) ||
                string.IsNullOrWhiteSpace(txbProductPrice.Text) ||
                cmbcategory.SelectedValue == null)
            {
                MessageBox.Show("invalid");
                return;
            }

            try
            {
                var product = new Product
                {
                    ProductId = int.Parse(txbproductId.Text),
                    ProductName = txtbProductN.Text,
                    Price = double.Parse(txbProductPrice.Text),
                    CatigoryId = (int)cmbcategory.SelectedValue
                };

                productService.Add(product);
                btnloadproduct.PerformClick();
                ClearProductFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" error" + ex.Message);
            }
        }


        private void btnUpdateproduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int id = int.Parse(txbproductId.Text);
                var product = productService.GetById(id);
                if (dgvProducts.CurrentRow != null)
                {

                    product.ProductName = txtbProductN.Text;
                    product.Price = double.Parse(txbProductPrice.Text);
                    product.CatigoryId = (int)cmbcategory.SelectedValue;

                    productService.Update(product);
                    btnloadproduct.PerformClick();
                    ClearProductFields();
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int id = (int)dgvProducts.CurrentRow.Cells["ProductId"].Value;
                productService.Delete(id);
                btnloadproduct.PerformClick();
                ClearProductFields();
            }

          
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvProducts.CurrentRow != null)
            {
                txbproductId.Text = dgvProducts.CurrentRow.Cells["ProductId"].Value?.ToString();
                txtbProductN.Text = dgvProducts.CurrentRow.Cells["ProductName"].Value?.ToString();
                txbProductPrice.Text = dgvProducts.CurrentRow.Cells["Price"].Value?.ToString();
                cmbcategory.Text = dgvProducts.CurrentRow.Cells["Category"].Value?.ToString();
            }
        }

        private void btnopenCategory_Click(object sender, EventArgs e)
        {
            var catForm = new Form2Category();
            catForm.ShowDialog();
            LoadCategories();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

            var userForm = new FormUsers();
            userForm.ShowDialog();

        }
    }
}
