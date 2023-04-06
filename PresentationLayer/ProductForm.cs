using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ProductForm : Form
    {
        // string barcode, string name, int quantity,
        // decimal price, Brand brand,
        // DateTime? bestBefore = null
        Brand selectedBrand;
        DbManager<Brand, int> brandManager = new DbManager<Brand, int>(ContextGenerator.GetBrandsContext());
        DbManager<Product, string> productManager = new DbManager<Product, string>(ContextGenerator.GetProductsContext());

        public ProductForm()
        {
            InitializeComponent();
            LoadBrands();
            LoadProducts();
        }

        #region Events

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidBarcode(barcodeTxtBox.Text) &&
                    ValidationManager.IsValidString(nameTxtBox.Text) &&
                    selectedBrand != null)
                {
                    string barcode = barcodeTxtBox.Text;
                    string name = nameTxtBox.Text;
                    int quantity = Convert.ToInt32(quantityBox.Value);
                    decimal price = priceBox.Value;
                    DateTime bestBefore = bestBeforeBox.Value;
                    Product product = new Product(barcode, name, quantity, price, selectedBrand, bestBefore);
                    productManager.Create(product);

                    MessageBox.Show("Product created successfully! 👍🏻", "⛏", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Barcode must be >= 10, you have to select Brand and enter name and barcode! 👎🏻", "⛏", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Helper Methods

        public void LoadBrands()
        {
            brandsListBox.DataSource = brandManager.ReadAll();
            brandsListBox.DisplayMember = StringConstants.Name;
        }

        public void LoadProducts()
        {
            productsDataGridView.DataSource = productManager.ReadAll();
        }

        #endregion

        private void brandsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brandsListBox.SelectedIndex >= 0 && brandsListBox.SelectedIndex < brandsListBox.Items.Count)
            {
                selectedBrand = brandsListBox.Items[brandsListBox.SelectedIndex] as Brand;
            }
        }
    }
}
