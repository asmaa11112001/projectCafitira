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
    public partial class Form2Category : Form
    {
        //private readonly CategoryServices categoryService;
        public Form2Category()
        {
            InitializeComponent();

            var context = new Context();
           // categoryService = new CategoryServices(context);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txCategoryid.Text, out int categoryId))
            {
                MessageBox.Show("Category ID must be a number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbCatName.Text))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            var newCategory = new Catigory
            {
                CatigoryId = categoryId, 
                CatigoryName = txbCatName.Text
            };

            try
            {
                using (var context = new Context()) 
                {
                    var service = new CategoryServices(context);

                  
                    if (context.Cateigorys.Any(c => c.CatigoryId == categoryId))
                    {
                        MessageBox.Show("Category with the same ID already exists.");
                        return;
                    }

                    service.Add(newCategory);
                }

                MessageBox.Show("Category added successfully.");
                txbCatName.Clear();
                txCategoryid.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}

