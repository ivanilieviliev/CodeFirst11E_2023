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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void brandBtn_Click(object sender, EventArgs e)
        {
            BrandForm brandForm = new BrandForm();
            brandForm.ShowDialog();
        }

        private void brandBtn_MouseHover(object sender, EventArgs e)
        {
            //brandsToolTip
        }

        public void CustomMethod(object sender, EventArgs e)
        {
            brandBtn.BackColor = Color.Chocolate;
        }

        private void brandBtn_MouseEnter(object sender, EventArgs e)
        {
            brandBtn.BackColor = Color.RosyBrown;
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }
    }
}
