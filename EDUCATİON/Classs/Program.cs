using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Classs
{
    class Program
    {
        static void Main()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Propertyler propertyler = new Propertyler();

            propertyler.ID = 1452;
            propertyler.FirstName = "İsmail";
            propertyler.LastName = "Erdoğan";

            // Alttaki de üstteki de sınıf için olur.

            Propertyler propertyler2 = new Propertyler 
            {
                ID =1451 ,FirstName ="Aleyna",City ="Ankara", LastName ="Akbulut" 

            };

            Console.WriteLine(propertyler2.City);



            Console.ReadLine();
        }


    }
}