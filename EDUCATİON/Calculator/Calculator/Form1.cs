using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private char _İslem;
        private bool _TemizlensinMi;
        private int _İlkSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_TemizlensinMi)
            {
                Ekran.Text = ""; // true veya false old. için = koymadık. Sayıya basınca ekranda silsn
                _TemizlensinMi = false; // çnk 36+45 yazmak için 4 e basınca ekranı tekrar temizler. Bunu engellemek içn
            }
            if(Ekran.Text=="0") Ekran.Text="";

            Ekran.Text += "1";
        }

        private void rakam2_Click(object sender, EventArgs e)
        {
            if (_TemizlensinMi)
            {
                Ekran.Text = ""; // true veya false old. için = koymadık. Sayıya basınca ekranda silsn
                _TemizlensinMi = false; // çnk 36+45 yazmak için 4 e basınca ekranı tekrar temizler. Bunu engellemek içn
            }
            if (Ekran.Text == "0") Ekran.Text = "";

            Ekran.Text += "2";
        }

        private void rakam3_Click(object sender, EventArgs e)
        {
            if (_TemizlensinMi)
            {
                Ekran.Text = ""; // true veya false old. için = koymadık. Sayıya basınca ekranda silsn
                _TemizlensinMi = false; // çnk 36+45 yazmak için 4 e basınca ekranı tekrar temizler. Bunu engellemek içn
            }
            if (Ekran.Text == "0") Ekran.Text = "";

            Ekran.Text += "3";
        }

        private void rakam4_Click(object sender, EventArgs e)
        {
            if (_TemizlensinMi)
            {
                Ekran.Text = ""; // true veya false old. için = koymadık. Sayıya basınca ekranda silsn
                _TemizlensinMi = false; // çnk 36+45 yazmak için 4 e basınca ekranı tekrar temizler. Bunu engellemek içn
            }
            if (Ekran.Text == "0") Ekran.Text = "";

            Ekran.Text += "4";
        }

        private void rakam5_Click(object sender, EventArgs e)
        {
            if (_TemizlensinMi)
            {
                Ekran.Text = ""; // true veya false old. için = koymadık. Sayıya basınca ekranda silsn
                _TemizlensinMi = false; // çnk 36+45 yazmak için 4 e basınca ekranı tekrar temizler. Bunu engellemek içn
            }
            if (Ekran.Text == "0") Ekran.Text = "";

            Ekran.Text += "5";
        }

        private void rakam6_Click(object sender, EventArgs e)
        {
            if (_TemizlensinMi)
            {
                Ekran.Text = ""; // true veya false old. için = koymadık. Sayıya basınca ekranda silsn
                _TemizlensinMi = false; // çnk 36+45 yazmak için 4 e basınca ekranı tekrar temizler. Bunu engellemek içn
            }
            if (Ekran.Text == "0") Ekran.Text = "";

            Ekran.Text += "6";
        }

        private void rakam7_Click(object sender, EventArgs e)
        {
            if (_TemizlensinMi)
            {
                Ekran.Text = ""; // true veya false old. için = koymadık. Sayıya basınca ekranda silsn
                _TemizlensinMi = false; // çnk 36+45 yazmak için 4 e basınca ekranı tekrar temizler. Bunu engellemek içn
            }
            if (Ekran.Text == "0") Ekran.Text = "";

            Ekran.Text += "7";
        }

        private void rakam8_Click(object sender, EventArgs e)
        {
            if (_TemizlensinMi)
            {
                Ekran.Text = ""; // true veya false old. için = koymadık. Sayıya basınca ekranda silsn
                _TemizlensinMi = false; // çnk 36+45 yazmak için 4 e basınca ekranı tekrar temizler. Bunu engellemek içn
            }
            if (Ekran.Text == "0") Ekran.Text = "";

            Ekran.Text += "8";
        }

        private void rakam9_Click(object sender, EventArgs e)
        {
            if (_TemizlensinMi)
            {
                Ekran.Text = ""; // true veya false old. için = koymadık. Sayıya basınca ekranda silsn
                _TemizlensinMi = false; // çnk 36+45 yazmak için 4 e basınca ekranı tekrar temizler. Bunu engellemek içn
            }
            if (Ekran.Text == "0") Ekran.Text = "";

            Ekran.Text += "9";
        }

        private void rakam0_Click(object sender, EventArgs e)
        {
            if (_TemizlensinMi)
            {
                Ekran.Text = ""; // true veya false old. için = koymadık. Sayıya basınca ekranda silsn
                _TemizlensinMi = false; // çnk 36+45 yazmak için 4 e basınca ekranı tekrar temizler. Bunu engellemek içn
            }
            if (Ekran.Text == "0") Ekran.Text = "";

            Ekran.Text += "0";
        }

        private void topla_Click(object sender, EventArgs e)
        {
            _İslem = '+';
            _TemizlensinMi = true;
            _İlkSayi=Convert.ToInt32(Ekran.Text);
        }

        private void sonuc_Click(object sender, EventArgs e)
        {
            int İkinciSayi = Convert.ToInt32(Ekran.Text);
            int sonuc;

            switch (_İslem)
            {
                case '+':
                    sonuc = _İlkSayi + İkinciSayi;
                    break;
                case '-':
                    sonuc = _İlkSayi - İkinciSayi;
                    break;
                case '/':
                    sonuc = _İlkSayi / İkinciSayi;
                    break;
                case '*':
                    sonuc = _İlkSayi * İkinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            Ekran.Text = Convert.ToString(sonuc);

        }

        private void carp_Click(object sender, EventArgs e)
        {
            _İslem = '*';
            _TemizlensinMi=true;
            _İlkSayi = Convert.ToInt32(Ekran.Text);
        }

        private void Ekran_Click(object sender, EventArgs e)
        {

        }

        private void böl_Click(object sender, EventArgs e)
        {
            _İslem = '/';
            _TemizlensinMi = true;
            _İlkSayi = Convert.ToInt32(Ekran.Text);
        }

        private void çıkart_Click(object sender, EventArgs e)
        {
            _İslem = '-';
            _TemizlensinMi = true;
            _İlkSayi = Convert.ToInt32(Ekran.Text);
        }

        private void resetle_Click(object sender, EventArgs e)
        {
            Ekran.Text = "0";
            
        }
    }
}
