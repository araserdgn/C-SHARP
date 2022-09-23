using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapeDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger=new FileLogger();
            customerManager.Add();
            
            
            
            

            Console.ReadLine();
        }

        class CustomerManager
        {
            public ILogger Logger { get; set; }
            public void Add ()
            {
                Logger.log();
                Console.WriteLine("Customer Added.");
            }
        }

        class DataBaseLogger:ILogger
        {
            public void log()
            {
                Console.WriteLine("Logged to DataBase!");
            }


        }

        class FileLogger : ILogger
        {
            public void log()
            {
                Console.WriteLine("Logged to FileBase!");
            }
        }

        interface ILogger
        {
            void log();
        }

    }
}
