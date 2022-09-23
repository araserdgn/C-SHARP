using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Age=23,FirstName="İsmail"};
            CustomerDal customerdal= new CustomerDal();
            customerdal.Add(customer);

            Console.ReadLine();

        }
    }
    [ToTable("Customer")]
    [ToTable("TblCustomer")] // AllowMulti true çunji o yzden kullanabildik
    class Customer
    {
        [RequiredProperty]
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        [RequiredProperty]

        public string LastName { get; set; }
        [RequiredProperty]

        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Don't use Add , instaed use AddNew")]
        public void Add (Customer customer)
        {
            Console.WriteLine("{0} , {1} , {2}, {3} added.!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0} , {1} , {2}, {3} added.!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)] // .All deseydi Aşagıdaki attribute herkes kullanabilkir
    // AllowMultiple =true , birden fazla Required kulanablr mym demek
    class RequiredPropertyAttribute : FlagsAttribute
    {

    }
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)] // Required sadece classlara ekelnebilir
                                                                 
    class ToTableAttribute : FlagsAttribute
    {
        private string _firstName;

        public ToTableAttribute(string ToTable)
        {
            _firstName = ToTable;
        }
    }
}
