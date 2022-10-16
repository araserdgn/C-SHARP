using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProducdtManager producdtManager = new ProducdtManager(new Factory2());
            producdtManager.GetAll();

            Console.ReadLine();
        }
    }
    public abstract class Logging //*//
    {
        public abstract void Log(string message);
    }
    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logger with lognetLogger.");
        }
    }
    public class NLogger:Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logger with NLogger");
        }
    }
    public abstract class Caching //*//
    {
        public abstract void Cache(string data);
    }
    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with MemCache");
        }
    }
    public class RedisCache:Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with RedisCache");
        }
    }
    // FABRİKAYI KURALIM ŞİMDİ
    public abstract class CrossCuttingConcernsFactory1
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCaching();
    }
    // BAŞKA BİR FABRİKALAR ÜRETELİM ŞİMDİ
    public class Factory1 : CrossCuttingConcernsFactory1 // ---
    {
        public override Caching CreateCaching()
        {
            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            return new Log4NetLogger();
        }
    }

    public class Factory2 : CrossCuttingConcernsFactory1 // ---
    {
        public override Caching CreateCaching()
        {
            return new MemCache();
        }

        public override Logging CreateLogger()
        {
            return new NLogger();
        }
    }
    // CLİENT(kullanan) kısma gelelim şimdi
    public class ProducdtManager
    {
        CrossCuttingConcernsFactory1 _crossCuttingConcernsFactory1;
        private Logging _logging;
        private Caching _caching;
        public ProducdtManager(CrossCuttingConcernsFactory1 crossCuttingConcernsFactory1)
        {
            _crossCuttingConcernsFactory1 = crossCuttingConcernsFactory1;
            _caching = _crossCuttingConcernsFactory1.CreateCaching();
            _logging=_crossCuttingConcernsFactory1.CreateLogger();
        }

        public void GetAll()
        {
            _logging.Log("Logged");
            _caching.Cache("Data");
            Console.WriteLine("Procuts listed.");
        }

    }

}
