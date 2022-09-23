using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHazırlık2
{
    
    internal class Program
    {
        //class cevir
        //{
        //    public int this [int deger]
        //    {
        //        get
        //        {
        //            return (deger * (deger % 3)); // okuma işlemini burdan alır , CONSOLE kısmı
        //        }
        //        set
        //        {
        //            deger = value; // main içinde değer atarsan buradan yapar
        //        }
        //    }

        class A
        {
            static protected int a = 10;
            public virtual void Insert()
            {
                Console.WriteLine("Program in A class ."+a);
            }
        }
        class B:A
        {
            static int a = 20;
            public override void Insert()
            {
                Console.WriteLine("Program in B class ."+a);
            }
        }
        class C:B
        {
            public void Insert()
            {
                Console.WriteLine("C inideyiz");
            }
        }

        //}


        static void Main(string[] args)
        {
            //cevir sayı = new cevir();

            //Console.WriteLine(sayı[5]);


            //Console.WriteLine("");

            C c = new C();
            A yeni;

            yeni = c;
            yeni.Insert();
            

            Console.ReadLine();
        }
    }
}

