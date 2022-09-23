using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(Stublogger.GetLogger());
            customerManager.Save();

            Console.ReadLine();

            
        }
    }
    class CustomerManager
    {
        public ILog _log;

        public CustomerManager(ILog log)
        {
            _log = log;
        }
        public void Save()
        {
            Console.WriteLine("Saved");
        }
    }
    interface ILog
    {
        void Log();
    }
    class Log4Net : ILog
    {
        public void Log()
        {
            Console.WriteLine("Logged with Log4Net");
        }
    }
    class NLogNet : ILog
    {
        public void Log()
        {
            Console.WriteLine("Logged with nLogNet");
        }
    }
    class Stublogger : ILog
    {
        private static Stublogger _stublogger;
        private static object _lock = new object();

        private Stublogger()
        {

        }
        public static Stublogger GetLogger()
        {
            lock (_lock)
            {
                if (_stublogger==null)
                {
                    _stublogger = new Stublogger();
                }
            }
            return _stublogger;
        }
        public void Log()
        {
            
        }
    }
    class CsutomerManagertest
    {
        public void SaveTest ()
        {
            CustomerManager manager = new CustomerManager(Stublogger.GetLogger());
            manager.Save();
        }
    }
}
