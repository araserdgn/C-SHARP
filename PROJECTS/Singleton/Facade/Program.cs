using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();

            Console.ReadLine();
        }
    }
    class Logging :ILogging//*
    {
        public void Log()
        {
            Console.WriteLine("Loggedded.!");
        }
    }

    internal interface ILogging
    {
        void Log();
    }

    class Caching:ICaching //*
    {
        public void Cache()
        {
            Console.WriteLine("Cached.!");
        }
    }

    internal interface ICaching
    {
        void Cache();
    }

    class Autorize:IAutorize //*
    {
        public void ChechUser()
        {
            Console.WriteLine("Autorized.!");
        }
    }

    internal interface IAutorize
    {
        void ChechUser();
    }
    class Clone:IClone
    {
        public void ClonWrite()
        {
            Console.WriteLine("Clonned...");
        }
    }

    internal interface IClone
    {
        void ClonWrite();
    }

    class CustomerManager
    {
        private CrossCuttingConcernsFacade _concerns;

        public CustomerManager()
        {
            _concerns=new CrossCuttingConcernsFacade();
        }
        public void Save()
        {
            _concerns.Caching.Cache();
            _concerns.Logging.Log();
            _concerns.Autorize.ChechUser();
            _concerns.Clone.ClonWrite();

            Console.WriteLine("Savedd");
        }
    }
    class CrossCuttingConcernsFacade
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAutorize Autorize;
        public IClone Clone;

        public CrossCuttingConcernsFacade()
        {
            Logging = new Logging();
            Caching = new Caching();
            Autorize = new Autorize();
            Clone =new Clone();
        }
    }
}
