using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerObserver= new CustomerObserver();
            ProductManager productManager = new ProductManager();
            
            productManager.Attach(customerObserver); // EKLE 
            productManager.Attach(new CustomerObserver());
            productManager.Detach(customerObserver); //ÇIKAR
            productManager.UpdatePrice();
            
            

            Console.ReadLine();
        }
    }
    class ProductManager
    {
        List<Observer> _obServer = new List<Observer>();
        public void UpdatePrice ()
        {
            Console.WriteLine("Product price changed.");
            Notify(); // ABONELER BİLGİLENDİr
        }
        public void Attach (Observer observer)
        {
            _obServer.Add(observer);
        }
        public void Detach(Observer observer) // ABONE ÇIKAR
        {
            _obServer.Remove(observer);
        }
        private void Notify ()
        {
            foreach (var ob in _obServer)
            {
                ob.Update();
            }
        }

    }
    abstract class Observer //**
    {
        public abstract void Update();
    }
    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to customer : Product price changed.");
        }
    }
    class EmployeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to Employe : Product price changed.");
        }
    }
}
