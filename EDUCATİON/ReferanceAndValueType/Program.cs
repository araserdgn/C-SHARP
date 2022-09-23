using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2); // ekrana 10 basar cunku anlık olarak num1 değeri num2 oldu

            string[] cities1 = { "Ankara", "İzmir", "Bolu" };
            string[] cities2 = { "Mardin", "Antep", "Urfa" };
            cities2= cities1; // artık cities2 cities1'in içini işaret ediyor.

            cities2[0] = "Samsun";

            Console.WriteLine(cities1[0]);

            DataTable dataTable = new DataTable(); // Bu bellek için pahalı bir durum çünkü
            DataTable dataTable2 = new DataTable(); // new yapmak masraflıdır. table zaten table 2 yi gösteriyor
            dataTable = dataTable2;

            DataTable dataTable;                    // Bu sekilde olmalı dogrusu budur
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;

            Console.ReadLine ();

        }
    }
}
