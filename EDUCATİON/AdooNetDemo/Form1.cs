using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdooNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Name = txName.Text,
                UnitPrice= Convert.ToDecimal(txUnitPrice.Text),
                StockAmount= Convert.ToInt32(txStockAmount.Text),

            }) ;
            LoadProducts();
            MessageBox.Show("Product added.!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = txNameUpdate.Text,
                UnitPrice=Convert.ToDecimal(txUnitPriceUpdate.Text),
                StockAmount=Convert.ToInt32(txStockAmountUpdate.Text)
            };

            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Updated!!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();

            MessageBox.Show("Deleted.!!");
        }
    }
}
