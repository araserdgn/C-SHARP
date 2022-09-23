using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecaptProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategories();
            ListProducts(); // ekrana listeleme metodu
        }

        private void ListProducts() // DataGrivde ekrana veritabandan Products'ları ekrana listeleme metodu
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.ToList();
            }
        }
        private void ListProductsByCategory(int CategoryId) // DataGrivde ekrana veritabandan Products'ları ekrana listeleme metodu
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p=>p.CategoryId==CategoryId).ToList(); // DELEGE kullandık
                // Products içine git ama WHERE ( filtrele) benim gönderdiğim CategoryId leri demek
            }
        }
        private void ListCategories() // DataGrivde ekrana veritabandan Products'ları ekrana listeleme metodu
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName"; // ComboBoxa basınca görünecek isimler
                cbxCategory.ValueMember = "CategoryId"; // Degerleri de Filtreleme de Id Lerine göre olacak yani
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception)
            {

                
            }
            // MessageBox.Show(cbxCategory.SelectedValue.ToString()); // seçtiğinde kaçıncı sırada oldugunu gösterir.
        }
        private void ListProductsByProductSearch(string key) // Search yerine yazdıgımızda filtreleme yapan metod
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList(); // DELEGE kullandık
                // Products içine git CONTAİNS ( içeriyorsa) girdiğim kelimeyi onu listele
            }
        }



        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key=tbxSearch.Text;

            if(string.IsNullOrEmpty(key)) // arama yeri boş veya sıfır ise
            {
                ListProducts();     // bütün ürünleri tekrar ekrana getir demek
            }
            else
            {
                ListProductsByProductSearch(tbxSearch.Text);
            }
            
        }
    }
}
