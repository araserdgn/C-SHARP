using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FİNALHAZILIK
{

    internal class Program
    {
        class kure
        {
            int a, b;
            public kure()
            {
                a = b = 0;
            }
            public kure(int x, int y)
            {
                this.a = x;
                this.b = y;
            }

            public static kure operator +(kure x, kure y)
            {
                kure c = new kure();
                c.a = x.a + y.a;
                c.b = x.b + y.b;
                return c;
            }
            public void yazdır()
            {
                Console.WriteLine(a + " / " + b);
            }

        }

        class TekSayılar
        {
            public void tekler(params int[] sayılar)
            {
                List<int> liste = new List<int>();

                if (sayılar.Length == 0)
                {
                    Console.WriteLine("Hatalı girdi");
                }

                else
                {
                    foreach (var i in sayılar)
                    {
                        if (i % 2 != 0)
                            liste.Add(i);

                    }

                }
                foreach (var j in liste)
                {
                    Console.Write(j + " ");
                }

            }


        }


        static void Main(string[] args)
        {
            TekSayılar ob = new TekSayılar();

            Console.WriteLine("Tek sayıların listesi: ");

            ob.tekler(11, 20, 7, 5, 51, 555, 100, 95);

            //kure ob1 = new kure(10, 5);
            //kure ob2 = new kure(5, -2);
            //kure ob3;

            //Console.WriteLine("ob1 yazdır.");
            //ob1.yazdır();
            //Console.WriteLine("ob1 yazdır.");
            //ob2.yazdır();
            //ob3 = ob1 + ob2;
            //Console.WriteLine("ob3 yazdır.");
            //ob3.yazdır();







            Console.ReadLine();

        }
    }
}


