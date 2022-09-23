using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizinin eleman sayısını giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());  
            int[] sayılar=new int[n];
            int min,gecici;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Dizinin {0}. Sayısını giriniz: ",i+1);
                sayılar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(sayılar); // kucukten buyuge sıralama METOTDU
            // dizinin içi şimdi düzenlendi
            

            Console.WriteLine("Sıralı halleri ");
            Console.Write("Kucukten buyuge: ");
            foreach (var i in sayılar)
            {
                Console.Write(i+" ");
            }
            Array.Reverse(sayılar);
            Console.WriteLine("-------");
            Console.Write("buyukten kucuge: ");
            foreach (var j in sayılar)
            {
                Console.Write(j + " ");
            }

            //for (int i = 0; i < n-1; i++)
            //{
            //    min=i;
            //    for (int j = i+1; j < n; j++)
            //    {
            //        if(sayılar[j]<sayılar[min])
            //        {
            //            min = sayılar[j];
            //        }
            //        gecici=sayılar[min];
            //        sayılar[min]=sayılar[i];
            //        sayılar[i] = gecici;
            //    }

            //}
            //Console.Write("Kucukten buyuge sıralı şekli >>> ");
            //foreach (var i in sayılar)
            //{
            //    Console.Write(i+" ");
            //}



            Console.ReadLine();            
        }
    }
}
