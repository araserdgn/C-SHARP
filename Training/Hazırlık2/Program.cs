using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazırlık2
{
    internal class Program
    {
        class kure
        {
            double r;
        
                public kure() { 
                r = 0; 
            }
                public kure (double a)
                {
                    r = (a < 0) ? 0 : r;
                }
                public double alanHesapla()
                {
                    return 4 * 3.14 * r * r;

                }

            public static kure operator +(kure a,kure b)
            {
                int r;
                
                return r;
            }
            }

            static void Main(string[] args)
            {
            //string metin;
            //int uzun;
            //Console.WriteLine("Metin giriniz: ");
            //metin=Console.ReadLine();
            //uzun = metin.Length;

            //for(int i=uzun-1; i>=0;i-- )
            //{
            //    Console.Write(metin[i]);
            //}
            kure kure = new kure(5.0);
            Console.WriteLine("YAZALIM");
            Console.WriteLine(kure.alanHesapla());
            
                Console.ReadLine();
            }
        }
    }

