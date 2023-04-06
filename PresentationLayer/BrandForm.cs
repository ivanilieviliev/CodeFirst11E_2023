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
    public partial class BrandForm : Form
    {
        private DbManager<Brand, int> dbManager = new DbManager<Brand, int>(ContextGenerator.GetBrandsContext());
        private Brand selectedBrand;

        public BrandForm()
        {
            InitializeComponent();
            LoadBrands();
            brandsDataGridView.ReadOnly = true;
        }

        #region Events

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidString(nameTxtBox.Text)
                    && ValidationManager.IsValidString(emailTxtBox.Text)
                    && ValidationManager.IsValidString(phoneTxtBox.Text))
                {
                    string name = nameTxtBox.Text;
                    string email = emailTxtBox.Text;
                    string phone = phoneTxtBox.Text;
                    string address = addressTxtBox.Text;

                    Brand brand = new Brand(name, email, phone, address);
                    dbManager.Create(brand);

                    MessageBox.Show("Brand created successfully! :)", "😎", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBrands();

                    ClearTextBoxes();

                    nameTxtBox.Focus();
                }
                else
                {
                    MessageBox.Show("You have to enter values in the text boxes! 🤨🤨🤨", "☹", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTxtBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "😭", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        
        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidString(nameTxtBox.Text)
                    && ValidationManager.IsValidString(emailTxtBox.Text)
                    && ValidationManager.IsValidString(phoneTxtBox.Text)
                    && selectedBrand != null)
                {
                    selectedBrand.Name = nameTxtBox.Text;
                    selectedBrand.Email = emailTxtBox.Text;
                    selectedBrand.Phone = phoneTxtBox.Text;
                    selectedBrand.Address = addressTxtBox.Text;

                    dbManager.Update(selectedBrand);
                    MessageBox.Show("Brand updated successfully! :)", "😎", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Choose brand from the table! 🧙‍♂", "👎🏼", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "😭", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedBrand != null)
                {
                    dbManager.Delete(selectedBrand.Id);
                    MessageBox.Show("Brand ☠️ successfully!", "💀", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    selectedBrand = null;
                    LoadBrands();
                }
                else
                {
                    MessageBox.Show("Choose brand from the table! 🧙‍♂", "👎🏼", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "😭", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brandsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("🔥");
                return;
            }
            selectedBrand = brandsDataGridView.Rows[e.RowIndex].DataBoundItem as Brand;
            FillTextBoxes();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            selectedBrand = null;
            ClearTextBoxes();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

#endregion

        #region Helper Methods

        private void ClearTextBoxes()
        {
            nameTxtBox.Text = string.Empty;
            emailTxtBox.Text = string.Empty;
            phoneTxtBox.Text = string.Empty;
            addressTxtBox.Text = string.Empty;
        }

        private void FillTextBoxes()
        {
            if (selectedBrand != null)
            {
                nameTxtBox.Text = selectedBrand.Name;
                emailTxtBox.Text = selectedBrand.Email;
                phoneTxtBox.Text = selectedBrand.Phone;
                addressTxtBox.Text = selectedBrand.Address;
            }
        }

        private void LoadBrands()
        {
            brandsDataGridView.DataSource = dbManager.ReadAll();
        }

#endregion
    }
}
