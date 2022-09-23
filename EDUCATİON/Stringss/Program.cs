
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Stringss
{
    class Program
    {
        static void Main ()
        {
            //StringÖzet();

            string sentence = "You fight we die for you Fenerbahce.!";

            var result = sentence.IndexOf("we"); // WE nerede baslıyor.
            Console.WriteLine(result);

            bool result1 = sentence.StartsWith("Fight"); // String ne ile baslıyor
            Console.WriteLine (result1);

            bool result2 = sentence.EndsWith("!");
            Console.WriteLine (result2);

            var result3 = sentence.Substring(4,10); // (4) karakterden sonra ekrana yazar
                                                    // (4,10) 4. kar. baslar ve sonraki 10 tanesini alır
            Console.WriteLine (result3);

            var result4 = sentence.Insert(0,"hello,"); // istediğin yere string ekleme.
            Console.WriteLine (result4);

            var result5 = sentence.ToLower();
            Console.WriteLine (result5);

            Console.ReadLine();
        }

        private static void StringÖzet()
        {
            string city = "ANKARA";
            string city1 = "İSTANBUL";
            string city2 = "MUĞLA";

            // Console.WriteLine (city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(String.Format("{0} {1} {2}", city, city1, city2)); // Kolayca string ekrana bastırma
        }
    }
}