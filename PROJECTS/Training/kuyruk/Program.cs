using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuyruk
{
    internal class Program
    {

        //public class TemelSinif
        //{
        //    protected string degisken_1 = "Temel Sınıf İçerisinde";
        //    public string degisken_2 = "Temel Sınıf İçerisinde";
        //    private string degisken_3 = "Temel Sınıf İçerisinde";
        //}

        //public class TuretilmisSinif : TemelSinif
        //{
        //    public void Metot_1()
        //    {
        //        degisken_1 = "Türetilmiş Sınıf İçerisinde";
        //        Console.WriteLine(degisken_1);
        //    }

        //    public void Metot_2()
        //    {
        //        degisken_2 = "Türetilmiş Sınıf İçerisinde";
        //    }

        //}

        class Musteri
        {
            private string AdSoyad;
            private ulong TCNo;
            private int OdaNo, sayi;
            public int this[int sayı]
            {
                get
                {
                    return sayı * (sayı % 3);
                }
                set
                {
                    sayı = value;
                }
            }
            public string adsoyad
            {
                get
                {
                    return adsoyad;
                }
                set
                {
                    AdSoyad = value;
                }
            }
            public ulong tcno
            {
                get
                {
                    return TCNo;
                }
                set
                {
                    if (value.ToString().Length == 11)
                        TCNo = value;
                    else
                        Console.WriteLine("HATA! TC Kimlik Numarası 11 Haneli Olmalıdır.");
                }
            }
            static void Main(string[] args)
            {
                //TuretilmisSinif ab = new TuretilmisSinif();
                //ab.Metot_1();
                //ab.Metot_2();
                //ab.degisken_2="iso";
                ///*ab.degisken_1();*/ // çagrılmaz PROTECTED cunku

                Musteri m1 = new Musteri();
                m1.adsoyad = "Serdar Yılmaz";  // adsoyad özelliğinin SET metodu çalıştı.
                m1.tcno = 14548617718;         // tcno özelliğinin SET metodu çalıştı.

                m1.sayi = 5;
                Console.WriteLine(m1.sayi);

                Console.WriteLine("Ad/Soyad:{0} - Tc No:{1}", m1.adsoyad, m1.tcno); // GET metodları çalıştı
                Console.ReadLine();
            }
        }
    }


