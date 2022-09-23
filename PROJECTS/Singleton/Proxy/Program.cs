using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditBase creditManager = new CreditManagerProxy();
            Console.WriteLine(creditManager.Calculater());
            Console.WriteLine(creditManager.Calculater());

            Console.ReadLine();
        }
    }

    abstract class CreditBase
    {
        public abstract int Calculater();
    }

    class CreditManager : CreditBase
    {
        public override int Calculater()
        {
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= i;

                Thread.Sleep(1000);
            }
            return result;
        }
    }
    class CreditManagerProxy : CreditBase
    {
        private CreditManager creditManager;
        int _cache;
        public override int Calculater()
        {
            if(creditManager == null)
            {
                creditManager = new CreditManager();
                _cache=creditManager.Calculater();
            }

            return _cache;
        }
    }
}
