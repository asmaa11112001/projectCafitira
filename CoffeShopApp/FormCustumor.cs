using BLL;
using DAL;
using CoffeShopApp.viewModel; // لازم الإضافة دي
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CoffeShopApp.viewModel;

namespace CoffeShopApp
{
    public partial class FormCustumor : Form
    {
        private readonly ProductServices productService;
        private BindingList<selectedProduct> selectedProducts = new BindingList<selectedProduct>();

        public FormCustumor()
        {
            InitializeComponent();
            productService = new ProductServices(new Context());
        }


        private void FormCustumor_Load(object sender, EventArgs e)
        {
            var products = productService.GetAll();
            dgvshowallproduct.DataSource = products;


            dgvSelectproduct.AutoGenerateColumns = true; 
            dgvSelectproduct.DataSource = selectedProducts;
            boxnumericUpDown.Minimum = 1;
            boxnumericUpDown.Maximum = 1000;

        }

        private void dgvshowallproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selected = (Product)dgvshowallproduct.Rows[e.RowIndex].DataBoundItem;

            var existing = selectedProducts.FirstOrDefault(p => p.ProductId == selected.ProductId);
            if (existing == null)
            {
                selectedProducts.Add(new selectedProduct
                {
                    ProductId = selected.ProductId,
                    ProductName = selected.ProductName,
                    Price = selected.Price,
                    Quantity = 1
                });
            }
            else
            {
                existing.Quantity += 1;
            }

            RefreshSelectedProductsGrid();
        }




        private void dgvSelectproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selected = selectedProducts[e.RowIndex];
            boxnumericUpDown.Value = selected.Quantity;
            boxnumericUpDown.Tag = selected.ProductId;
        }



        private void boxnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (boxnumericUpDown.Tag == null) return;

            int productId = (int)boxnumericUpDown.Tag;
            var product = selectedProducts.FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                product.Quantity = (int)boxnumericUpDown.Value;
                // التحديث بيحصل تلقائي بسبب INotifyPropertyChanged
                RefreshSelectedProductsGrid(); // نحسب الإجمالي
            }
        }



        private void RefreshSelectedProductsGrid()
        {
            dgvSelectproduct.Refresh();
            double total = selectedProducts.Sum(p => p.Total);
            txbtotalprice.Text = total.ToString("F2");
        }

    }
}
