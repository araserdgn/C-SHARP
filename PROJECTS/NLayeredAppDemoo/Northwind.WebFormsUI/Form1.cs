using Northwind.Bussines.Abstract;
using Northwind.Bussines.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Bussines.DependencyResolvers.Ninject;
using CSharpTest.Net.Interfaces;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private IProductService _productService; 
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            // ProductManager productManager = new ProductManager(new NhProductDal()); FARKLI BİR ŞEYLERİ LİSTELEYECEKSEN BÖYLE
            // NH ve ENTİTY DİYE SOYALARDA OLUSTURDUK. DEĞİŞTİRMEK KOLAY OLUR PROJE AMAÇLI
            LoadProduct();
            LoadCategories(); // varmıs gibi kodladık sonra altına olusturdu
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";

            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";
        }

        private void LoadProduct()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception)
            {
               
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbxProductName.Text)) { // text içinde değer varsa ona göre getir
            dgwProduct.DataSource=_productService.GetProductsByProductName(tbxProductName.Text);
            }
            else // eger değer yoksa
            {
                LoadProduct();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProductName2.Text,
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockAmount.Text)


                });
                MessageBox.Show("Ürün Veritabanınıza Eklendi");
                LoadProduct();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value), // id direkt yukardan al
                    ProductName = tbxUpdateProName.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                    UnitsInStock = Convert.ToInt16(tbxStockUpdate.Text),
                    QuantityPerUnit = tbxQuantityPerUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),

                });
                MessageBox.Show("Ürün Veritabanınızda Güncellendi");
                LoadProduct();

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row=dgwProduct.CurrentRow;
            tbxUpdateProName.Text=row.Cells[0].Value.ToString();
            cbxCategoryUpdate.SelectedValue=row.Cells[2].Value;
            tbxUnitPriceUpdate.Text=row.Cells[3].Value.ToString();
            tbxQuantityPerUpdate.Text=row.Cells[4].Value.ToString();
            tbxStockUpdate.Text=row.Cells[5].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(dgwProduct.CurrentRow != null) {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün Veritabanınızda SİLİNDİ");
                    LoadProduct();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }
           
        }
    }
}
