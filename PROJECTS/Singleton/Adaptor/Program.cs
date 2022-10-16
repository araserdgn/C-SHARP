using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Log4NetAdapter());
            productManager.Save();

            Console.ReadLine();
        }
    }
    class ProductManager
    {
        ILogger _logger;
        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Save()
        {
            _logger.Log("Use Data");
            Console.WriteLine("Saved");
        }
    }
    interface ILogger //*
    {
        void Log(string message);
    }
    class EdLogger : ILogger
    {
        public void Log(string message)
        {
           Console.WriteLine("EdLogger {0}",message);
        }
    }
    // Nuget yani dokunamıyoruz diyelim bu koda

    class Log4net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Logged with Log4net, {0}", message);
        }
    }
    class Log4NetAdapter : ILogger
    {
        public void Log(string message)
        {
            Log4net log4Net = new Log4net();
            log4Net.LogMessage(message);
        }
    }

}
