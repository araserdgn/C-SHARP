using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { FirstName="İsmail",LastName="Erdoğan",City="Angara",Id=1};

            var customer2 =(Customer) customer1.Clone();
            customer2.FirstName = "Aras";
            customer2.City = "İstanbul";

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();

        }
    }
    public abstract class Person
    {
        public abstract Person Clone();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Customer:Person // elimizdekinden birtane daha olstururz
    {
        public string City { get; set; }

        public override Person Clone() // klonlama işlemi yapıldı
        {
            return (Person)MemberwiseClone();
        }
    }
    public class Employe : Person // elimizdekinden birtane daha olstururz
    {
        public decimal Salary { get; set; }

        public override Person Clone() // klonlama işlemi yapıldı
        {
            return (Person)MemberwiseClone();
        }
    }
}
