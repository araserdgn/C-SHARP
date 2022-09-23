using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockManager stockManager = new StockManager();
            BuyStock buyStock = new BuyStock(stockManager);
            SellStock selyStock = new SellStock(stockManager);

            StockControler stockControler = new StockControler();
            stockControler.TakeOrder(buyStock);
            stockControler.TakeOrder(selyStock);
            stockControler.TakeOrder(buyStock);

            stockControler.PaysOrders();

            Console.ReadLine();

        }
    }

    class StockManager
    {
        private string _name = "Laptop";
        private int _quantity = 10;

        public void Buy ()
        {
            Console.WriteLine("Stock : {0} , {1} bought!",_name,_quantity);

        }

        public void Sell()
        {
            Console.WriteLine("Stock : {0} , {1} sold!", _name, _quantity);

        }

    }
    interface IOrder
    {
        void Execute();
    }
    class BuyStock : IOrder
    {
        StockManager _manager;
        public BuyStock(StockManager stockManager)
        {
            _manager=stockManager;
        }
        public void Execute()
        {
            _manager.Buy();
        }
    }

    class SellStock : IOrder
    {
        StockManager _manager;
        public SellStock(StockManager stockManager)
        {
            _manager = stockManager;
        }
        public void Execute()
        {
            _manager.Sell();
        }
    }

    class StockControler
    {
        List<IOrder> _orders = new List<IOrder>();
        public void TakeOrder (IOrder order)
        {
            _orders.Add(order);
        }

        public void PaysOrders ()
        {
            foreach (var order in _orders)
            {
                order.Execute();
            }

            _orders.Clear();
        }
    }
}
