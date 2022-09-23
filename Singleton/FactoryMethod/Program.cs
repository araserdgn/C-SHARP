﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new LoggerFactory2());
            customerManager.Save();

            Console.ReadLine();
        }
    }
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreatLogger()
        {
            // bussines to decide factory
            return new EdLogger();
        }
    }

    public class LoggerFactory2 : ILoggerFactory
    {
        public ILogger CreatLogger()
        {
            // bussines to decide factory
            return new Log4NetLogger();
        }
    }

    public interface ILoggerFactory
    {
        ILogger CreatLogger();
    }
    public interface ILogger
    {
        void Log();
    }
    public class EdLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with Edlogger");
           
        }
    }

    public class Log4NetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with Log4Netlogger");

        }
    }

    public class CustomerManager
    {
        private ILoggerFactory _loggerFactory;

        public CustomerManager(ILoggerFactory loggerfactory)
        {
            _loggerFactory = loggerfactory;
        }
        public void Save() {
            Console.WriteLine("Saved!!");
            ILogger logger = _loggerFactory.CreatLogger();
            logger.Log();
        }
    }
    

}
