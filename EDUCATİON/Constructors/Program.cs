using AccesModifiles; // kullanacagın proje tanımlaman lazım
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Course course = new Course();
            Ayzo ayzo = new Ayzo();

            CustomerManager customerManager = new CustomerManager();
            customerManager.List(15);

            Product product2 = new Product(2, "iso");

            /*   EmplyeManager emplyeManager = new EmplyeManager();
               emplyeManager.Logger = new DatabaseLogger(); // İnterface Loggeri eklemiş olduk
               emplyeManager.Add(); */

              EmplyeManager emplyeManager = new EmplyeManager(new FileLogger()); // üstteki contr. olmadan tanımlanan
                    emplyeManager.Add();

            PersonMAnager personMAnager = new PersonMAnager("selamm");
            personMAnager.ekle();


            Deneme.number = 10;
            Utility.valide();

            Manager.DoSomething(); // static ile açılan kısım 

            Manager manager2 = new Manager(); // void ile açılan kısımı 
            manager2.DoSomething2();            // bu sekilde caıgrırız


            Console.ReadLine();
           
        }
 
    }

    class CustomerManager
    {
        private int _count;
        public void List(int count)
        {
            Console.WriteLine("Listed! "+count+" is good.");
        }
        public void Add()
        {
            Console.WriteLine("Added.!");
        }
    }

    class Product
    {
        public string _Name { get; set; }
        public int _İD { get; set; }


        private string _name { get; set; }
        private int _id { get; set; }
        public Product(int id,string name)
        {
            _name=name;
        }


    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database.");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Filee.");
        }
    }

    class EmplyeManager
    {   
        private ILogger _logger;
        public EmplyeManager(ILogger logger) // Contstructor ile yaptık , 
        {
            _logger= logger; // girilecek olan loggeri _loggere attım ki o da özelliklerine erişim sğalasın
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added.!");
        }
    }


    class BaseClas
    {
        private string _name;
        public BaseClas(string name)
        {
            _name = name;
        }

        public void ekle ()
        {
            Console.WriteLine("{0} message", _name);
        }
    }

    class PersonMAnager:BaseClas
    {
        public PersonMAnager(string name):base(name) // Base class içine isteneni gönderdim yani
        {

        }

        public void Add()
        {
                Console.WriteLine("Added.");
        }
    }

    static class Deneme
    {
        public static int number;
           
    }
    static class Utility
    {
        public static void valide()
        {
            Console.WriteLine("Unitily is valide.");
        }


    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("DoSomething.");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Something 2.");
        }
    }



}
