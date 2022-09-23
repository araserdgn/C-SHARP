using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace SuveTupTakip
{
   
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sutup.accdb"); // veritabanını cagırdık
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }
        void listele ()
        {
            baglanti.Open ();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from sutup",baglanti);
            adtr.Fill(ds, "sutup");
            dataGridView1.DataSource = ds.Tables["sutup"];
            adtr.Dispose ();
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if(tbxSıraNo.Text !="")
            {
                baglanti.Open();
                adtr = new OleDbDataAdapter("Select * from sutup where s_no" + Convert.ToInt32(tbxSıraNo.Text), baglanti);// sıra no göre tabandan ara
                VeriTaban();
            }
            if (tbxUrunKod.Text != "")
            {
                baglanti.Open();
                adtr = new OleDbDataAdapter("Select * from sutup where urun_kodu" + (tbxUrunAd.Text)+"'", baglanti);// sıra no göre tabandan ara
                VeriTaban();
            }
            if (tbxUrunAd.Text != "")
            {
                baglanti.Open();
                adtr = new OleDbDataAdapter("Select * from sutup where urun_adı" + (tbxUrunAd.Text) + "'", baglanti);// sıra no göre tabandan ara
                VeriTaban();
            }
            if (tbxAlan.Text != "")
            {
                baglanti.Open();
                adtr = new OleDbDataAdapter("Select * from sutup where alan_kişi" + (tbxAlan.Text) + "'", baglanti);// sıra no göre tabandan ara
                VeriTaban();
            }
            if (tbxTarih.Text != "")
            {
                baglanti.Open();
                adtr = new OleDbDataAdapter("Select * from sutup where a_tarih" + (tbxTarih.Text) + "'", baglanti);// sıra no göre tabandan ara
                VeriTaban();
            }
            if (tbxGaranti.Text != "")
            {
                baglanti.Open();
                adtr = new OleDbDataAdapter("Select * from sutup where g_suresi" + (tbxGaranti.Text) + "'", baglanti);// sıra no göre tabandan ara
                VeriTaban();
            }
            if (tbxDurum.Text != "")
            {
                baglanti.Open();
                adtr = new OleDbDataAdapter("Select * from sutup where durum" + (tbxDurum.Text) + "'", baglanti);// sıra no göre tabandan ara
                VeriTaban();
            }
            if (tbxMiktar.Text != "")
            {
                baglanti.Open();
                adtr = new OleDbDataAdapter("Select * from sutup where miktar" + (tbxMiktar.Text) + "'", baglanti);// sıra no göre tabandan ara
                VeriTaban();
            }
            if (tbxBirim.Text != "")
            {
                baglanti.Open();
                adtr = new OleDbDataAdapter("Select * from sutup where b_fiyat" + (tbxBirim.Text) + "'", baglanti);// sıra no göre tabandan ara
                VeriTaban();
            }
        }

        private void VeriTaban()
        {
            ds.Clear();
            adtr.Fill(ds, "sutup");
            dataGridView1.DataSource = ds.Tables["sutup"];
            adtr.Dispose();
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c= MessageBox.Show("Veriyi silmek üzeresiniz!!","Dikkatli olun!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(c==DialogResult.Yes) // eger sileceksek ve YES demişsek
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "DElete grom sutup where s_no" + tbxSıraNo.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                ds.Clear();
                listele();

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(tbxSıraNo.Text!="" && tbxUrunKod.Text != "" && tbxUrunAd.Text != "" && tbxAlan.Text != "" && tbxTarih.Text != "" && tbxGaranti.Text != "" && tbxDurum.Text != "" && tbxMiktar.Text != "" && tbxBirim.Text != "")
            {
                komut.Connection =baglanti;
                komut.CommandText = "Insert Into sutup(s_no,urun_kodu,urun_adı,alan_kişi,a_tarih,g_suresi,durum,miktar,b_fiyat) Values ("+tbxSıraNo.Text+", '" + tbxUrunKod.Text + ", '" + tbxUrunAd.Text + ", '" + tbxAlan.Text + ", '" + tbxTarih.Text + ", '" + tbxGaranti.Text + ", '" + tbxDurum.Text + ", '" + tbxMiktar.Text + ", '" + tbxBirim.Text + ", '";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt basarılıdır.");
                ds.Clear();
                listele();
            }
            else
            {
                MessageBox.Show(" BOŞ ALANLARI DOLDURUNUZ EKSİK VERİGİRMEYİNİZ");
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            tbxSıraNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxUrunKod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxUrunAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxAlan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxTarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxGaranti.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxDurum.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbxMiktar.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbxBirim.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Update sutup set urun_kodu='" + tbxUrunKod.Text + "', urun_adi='" + tbxUrunAd.Text + "', alan_kişi='" + tbxAlan.Text + "', a_tarih='" + tbxTarih.Text + "', g_suresi='" + tbxGaranti + "', durum='" + tbxDurum + "', miktar='" + tbxMiktar + "', b_fiyat='" + tbxBirim;
            komut.ExecuteNonQuery();
            baglanti.Close();
            ds.Clear();
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxSıraNo.Text = "";
            tbxUrunKod.Text = "";
            tbxUrunAd.Text = ""; 
            tbxAlan.Text = "";
            tbxTarih.Text = "";
            tbxGaranti.Text = "";
            tbxDurum.Text = "";
            tbxMiktar.Text = "";
            tbxBirim.Text = "";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
