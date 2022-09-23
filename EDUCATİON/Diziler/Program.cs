using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Diziler
{

    class Program
    {
        static void Main()
        {
            //string[] students = new string[3];

            //students[0] = "İsmail Aras";
            //students[1] = "Ezgi";
            //students[2] = "Şule";

            string[] students = { "İsmail", "Kübra", "Ezgi", "Emin" }; // bellekte 3 tane bosluk olusturdu

            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //ÇOK BOYUTLU DİZİLER

            string[,] regions = new string[4, 2]
            {
                {"İStanbul","Yalova"},
                { "Ankara","Konya"},
                { "Urfa","MArdin"},
                 { "Muğla","İzmir"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= regions.GetUpperBound(1); k++)
                {
                    Console.WriteLine(regions[i, k]);
                }
                Console.WriteLine("*******");

            }
            Console.ReadLine();

        }
    }
}

    






