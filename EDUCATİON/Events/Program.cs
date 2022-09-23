using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products harddisk = new Products(50); 
            harddisk.Name = "HardDisk";
           
            Products GSM = new Products(50);
            GSM.Name = "GMS";
            GSM.StockControlEvent += GSM_StockControlEvent;
            

            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10); // her seferinde 10 ar tane sat
                GSM.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void GSM_StockControlEvent() // STATİC çalışma esnasındaki değişimleri kasteder
        {
            Console.WriteLine("GSM about the Finish!!");
        }
    }
}
