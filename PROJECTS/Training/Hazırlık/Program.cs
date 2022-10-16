using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazırlık
{

    class asal
    {
        int baslangic;
        public asal(int x)
        {
            if (x < 0) baslangic = 0;
            else baslangic = x;
        }
        public int this [int baslangıc]
        {
            get { 
                if(baslangic == 0)
                    return 0;
                return baslangic;
            }
            set {
                int i = 2;
                int kontrol = 0;
                baslangıc = value;
                while (i < baslangıc)
                {
                    
                    
                    if (baslangıc % i == 0)
                        kontrol++;

                    i++;
                }
                if (kontrol != 0)
                    Console.WriteLine("Girdiğiniz {0} sayı asal değildir.", baslangic = value);
                else if(kontrol == 0)
                    Console.WriteLine("Girdiğiniz {0} sayı asal", baslangic = value);

               
            }
        }


    }
    //class ThreeD
    //{
    //    int x, y, z;

    //    public ThreeD()
    //    {
    //        x = y = z = 0;
    //    }

    //    public ThreeD(int a , int b,int c)
    //    {
    //        this.x = a;
    //        this.y = b;
    //        this.z = c;
    //    }

    //    public static ThreeD operator +(ThreeD a,ThreeD b)
    //    {
    //        ThreeD c = new ThreeD();
    //       c.x = a.x + b.x;
    //        c.y = a.y + b.y;
    //        c.z = a.z + b.z;

    //        return c;
    //    }
    //    public void Show()
    //    {
    //        Console.WriteLine(x +"," +y+","+ z);
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            asal m1 = new asal(6);
            int sayı,sonuc;
            Console.WriteLine("Deger giriniz: ");
            sayı=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(m1[0] = sayı);
            

                //ThreeD a = new ThreeD(1, 2, 3);
                //ThreeD b = new ThreeD(10, 10, 10);
                //ThreeD c;
                //Console.Write("a noktası: ");
                //a.Show();
                //Console.WriteLine();
                //Console.Write("b noktası: ");
                //b.Show();
                //Console.WriteLine();
                //Console.Write("a+b toplam noktası: ");
                //c = a + b;
                //c.Show();
                //Console.WriteLine();
                //Console.Write("a+b+c toplam noktası: ");
                //c = a +b+c;
                //c.Show();
                //Console.WriteLine();



                Console.ReadLine();
        }
    }
}
