using System;

namespace CsharpOne
{
    class Dönguler
    {
        static void Main()
        {
            var sayı1 = 180;
            var sayı2 = 20;
            if (sayı1 > sayı2)
            {
                Console.WriteLine("{0} sayı BÜYÜKTÜr {1} sayıdan.", sayı1, sayı2);
            }
            else
            {
                Console.WriteLine("sayı olumsuz");
            }
            /*
            Console.WriteLine(sayı2 == 20 ? "Number is 20": "Number is not 20");
                                            //dogru ise       yanlıs ise bunu yazacak.
            */
            // Yukarıdaki karşılastırmanın Single Linesi yani kısa hali

            switch (sayı2)
            {
                case 20:
                    Console.WriteLine("Sayi 2 bastırdı");
                    break;
                case 10:
                    Console.WriteLine("Boşlukk");
                    break;
                default:
                    Console.WriteLine("Swtich çıktık.");
                    break;
            }


            Console.ReadLine();
        }
    }
}
