using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void StockControl();
    internal class Products
    {
        private int Stocks;
        public Products(int _stock)
        {
            Stocks = _stock;
        }
        public event StockControl StockControlEvent; //Bir hareket old. o harekete ek olarak yapılan işlemi yapmaya yarar.
        public string Name { get; set; }
        public int Stock { 
            get
            {
                return Stocks;
            } 
            set
            {
                Stocks = value;
                if(Stock<20 && StockControlEvent != null) // STock 20 den düşük ise Stock olan EVENT'e abone oluyoruz
                {
                    StockControlEvent();
                }
            } 
        }

        public void Sell(int amount)
        {
            Stock -= amount;

            Console.WriteLine("{1} Stock amount: {0}", Stock,Name);
        }
    }
}
