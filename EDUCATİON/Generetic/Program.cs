using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities= new Utilities();
            List<string> result=utilities.BuilList<string>("Ankara","İstanbul","İzmir");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuilList<Customer>(new Customer { FirstName = "ismail" }, new Customer { FirstName = "Şulee" });

                foreach(var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();

        }
    }

    class Utilities
    {
        public List<T> BuilList<T>(params T[] items) // T yerleri, generic tarzı. main ne yazarsan o tip döndür
        {
            return new List<T>(items);
        }
    }

    interface IProductDal:IRepository<Product>
    {

    }
    class Product:IEntity
    {

    }

    class Customer:IEntity
    {
        public string FirstName { get; set; }
    }

    interface ICustomerDal:IRepository<Customer>
    {


    }

    interface IStudentDal:IRepository<ProductDal> // sınıf olarak aldı, generic kısıtlamasından dolayı
    {                                           // hata verir cunk genericde IEnttiy den implement alma kısıtı var.
                                                // ProducDAl da Enttiyden implemnete almadıgı için ahta verir

    }
    interface IStudentDal2 : IRepository<int> // sınıf olarak almadı, generic kısıtlamasından dolayı sadece içine
    {                                         // sınıf tanımlayabilirz              
                                                        
    }
    class stud:IEntity // veri tabanı nesnesisin dedik
    {

    }
    interface IEntity
    {

    }

    interface IRepository<T> where T:class ,IEntity, new() // WHERE den sonra generic yapmak istersen sadece sınıf yapabilirsin kısıtlaması getirdk
    {
        // T, referansı class olmalı, İmplementi IEntity olcak , ve yenilenebilecek 
        // IRepository<T> where T:STRUCT yazsaydık da referans yerlerine sınıf değil, int string felan yazcaktık
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    class ProductDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
