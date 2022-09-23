using System;
using System.Collections.Generic;

namespace ConsoleApp16
{
    class Program
    {
        //class kesir
        //{
        //    int pay;
        //    int payda;
        //    public kesir ()
        //    {
        //        pay = payda = 0;
        //    }
        //    public kesir(int a,int b)
        //    {
        //        this.pay = a;
        //        this.payda = b;
        //    }

        //    public static kesir operator +(kesir x,kesir y)
        //    {
        //        kesir c = new kesir();
        //        c.pay=x.pay+ y.pay;
        //        c.payda = x.payda + y.payda;

        //        return c;
        //    }
        //    public void show()
        //    {
        //        Console.WriteLine(pay + " / " +payda);
        //    }
        //}

        ////class cevir
        ////{
            
        ////    public int this[int deger]
        ////    {

        ////        get
        ////        {

        ////            return (deger * (deger % 3));
        ////        }

        ////        set
        ////        {
        ////            Console.WriteLine("HATA");
        ////        }
        ////    }
        ////}
        ///  
         
        class tek
        {
            List<int> liste = new List<int>();
            public void saydır(params int [] deger)
            {


                if (deger.Length== -1)
                {
                    Console.WriteLine("Hatalı girdi");
                }
                else
                {
                    foreach (var i in deger)
                    {
                        liste.Add(i);
                    }
            }
        }
            public void yazdır()
            {
                foreach (var j in liste)
                {
                    Console.WriteLine(j);
                }
            }
        }
        static void Main (string[] args )
        {
            string metin;
            int deger, sayı;
            Random rastgele = new Random();
            //Console.WriteLine("Metin giriniz: ");
            //metin=Console.ReadLine();


            //for (int i = metin.Length-1; i >=0; i--)
            //{
            //    Console.Write(metin[i]);
            //}

            tek don = new tek();

            don.saydır(5, 7, 8, 9, 10, 15, 15, 20);
            don.yazdır();


            
            ////cevir saı = new cevir();

            ////for (int i = 0; i < 5; i++)
            ////{
            ////    Console.WriteLine("ındeks {0}: {1}",i,saı[5]);
            ////}







            //kesir ob1 = new kesir(5, 10);
            //kesir ob2 = new kesir(15, 20);
            //kesir ob3;

            //Console.WriteLine("OB1 KESRİNİN DEGERİ: ");
            //ob1.show();
            //Console.WriteLine("OB2 KESRİNİN DEGERİ: ");
            //ob2.show();
            //ob3 = ob1 + ob2;
            //Console.WriteLine("OB3 KESRİNİN DEGERİ: ");
            //ob3.show();



            Console.ReadLine();
        }

    }
}