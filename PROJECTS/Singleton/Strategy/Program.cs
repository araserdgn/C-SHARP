using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.creditCalculaterBase = new After2010Credit();
            customerManager.SaveCredit();

            customerManager.creditCalculaterBase = new Before2010Credit();
            customerManager.SaveCredit();

            Console.ReadLine();
        }
    }
    abstract class CreditCalculaterBase //**
    {
        public abstract void Calculate();
    }

    class Before2010Credit : CreditCalculaterBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using before 2010");
        }
    }

    class After2010Credit : CreditCalculaterBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using after 2010");
        }
    }

    class CustomerManager
    {
        public CreditCalculaterBase creditCalculaterBase { get; set; }
        // yukardaki adamın örneğini de main içinde vermemiz lazım
        public void SaveCredit()
        {
            Console.WriteLine("Customer manager bussines.");
            creditCalculaterBase.Calculate(); // değişcek ya o yuzden ekledik
        }
    }
}
