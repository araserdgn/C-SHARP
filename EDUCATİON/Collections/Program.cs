using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            //CollectionOzet();


            Dictionary<string, string> dictionary = new Dictionary<string, string>(); // Sözlük gibi düşün bunu, istediğin ve karşılıgı seklnde
            dictionary.Add("Suddenly", "Aniden");
            dictionary.Add("Light", "Hafif/Açık/Işık");
            dictionary.Add("away", "Uzak");

            Console.WriteLine(dictionary["Suddenly"]); // bu karşıma benim ANİDEN yazdıracak

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key); // bu ilk bastaki kelimeleri yazdırır
                Console.WriteLine(item.Value); // bu da 2. yani karşılıgını yazdırır
            }

            Console.WriteLine(dictionary.Count); // dic. kaç eleman oldugunu saydı

            Console.WriteLine(dictionary.ContainsKey("Light")); // diyor ki KEY'lerde LİGHT var mı? T/F birisini döner. T dönecek burda
            Console.WriteLine(dictionary.ContainsValue("Sandalte")); // diyor ki VALUE'lerde sandalye var mı ? F döner

            

           





            Console.ReadLine();
        }

        private static void CollectionOzet()
        {
            List<string> cities = new List<string>();
            cities.Add("Barbara");
            cities.Add("Carlaa <3");

            Console.WriteLine(cities.Contains("Barbara")); // Contains metodu array içnde Aradıgımız sey varsa T/F birini döner

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("******************");

            //cities.Add(5); // bu olmaz cunku < > içine string istedik 

            //List<Customer> customer = new List<Customer>();
            //customer.Add(new Customer { İd=5,FirstName="İso"});
            //customer.Add(new Customer { İd = 10, FirstName = "Erdoğan" });

            List<Customer> customer = new List<Customer>
            {
                new Customer{İd=5,FirstName="iso"},
                new Customer{İd=15,FirstName="Erdogan"}
            };


            var customer2 = new Customer
            {
                İd = 5,
                FirstName = "AliVeli"
            };
            customer.Add(customer2);
            customer.AddRange(new Customer[2]
            {
                new Customer{İd=1,FirstName="Fatma"},
                new Customer{İd=31,FirstName="Ezgiii"}
            }); // Bana ARRAY bazlı liste ver, ben içine eklerim diyo

            //customer.Clear();   * ARRAY içini TEMİZLER

            Console.WriteLine(customer.Contains(new Customer { İd = 5, FirstName = "iso" }));
            // FALSE dönmesi lazım çünkü NEW dediği anda baska bir referans atamış olur. FAKAT
            Console.WriteLine(customer.Contains(customer2));
            // TRUE döner çünkü customer içinde customer2 diye bir array var

            customer.Insert(0, customer2); // EN BAŞA CUSTOMER2 Yİ TEKRAR EKLEDİM
            customer.Remove(customer2); // CUSTOMER2 yi ilk buldugu yerden siler.
            Console.WriteLine("**************");
            foreach (var custom in customer)
            {
                Console.WriteLine(custom.FirstName);
            }
            var Count = customer.Count(); // Array içini sayar
            Console.WriteLine("Count : {0}", Count);
            Console.WriteLine("******************");

            var index = customer.IndexOf(customer2); // customer2 kaçıncı sırada onu buldurur
            Console.WriteLine("İndex : {0}", index);

            customer.Add(customer2);            // customer2 yi tekrar ekledik ki bu sefer sonraki nuamrayı dönsün
            var lastindex = customer.LastIndexOf(customer2); // 5 dönecek çünkü sondan basladı taramaya , diyo ki en sonuncuda
            Console.WriteLine("Last İndex: {0}", lastindex); // customer2 yi sondan aramaya basladı bu sefer




            Console.WriteLine("******************");
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("İsmail");
            cities.Add("Erdoğan");
            cities.Add(5);

            foreach (var i in cities)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Customer
    {
        public int İd { get; set; }
        public string FirstName { get; set; } 
    }

}
