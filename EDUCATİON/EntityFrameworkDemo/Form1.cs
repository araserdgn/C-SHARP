using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
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
        private void SearchProducts(string key)
        {
            var result = _productDal.GetByName(key); // veritabanından araştırmaya yaradı
            dgwProducts.DataSource = result;


            // asagıdaki veritaban olmadan arama
            //dgwProducts.DataSource = _productDal.GetAll().Where(p=>p.Name.Contains(key)).ToList();
            // herbir elemanın ismine bak key içeriyor mu incele
            // sonra listele onu


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name=txName.Text,
                UnitPrice=Convert.ToDecimal(txUnitPrice.Text),
                StockAmount=Convert.ToInt32(txStockAmount.Text),
            });
            LoadProducts();
            MessageBox.Show("Added.!!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product // güncelleme old. için ID degirmemz lazm
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = txNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(txUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(txStockAmountUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Updated.!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Deleted is winner..!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txSearch.Text);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            _productDal.GetById(1);
        }
    }
}
