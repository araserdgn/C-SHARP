using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yığın
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack <int> yıgın = new Stack<int>(1);
           
            yıgın.Push(1);
            yıgın.Push(5);
            yıgın.Push(7);
            yıgın.Push(9);
            yıgın.Push(11);
            yıgın.Push(13);
            

            foreach(var i in yıgın)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Kaç tane: " + yıgın.Count());
            Console.WriteLine("Peek degeri: " + yıgın.Peek());
            Console.WriteLine("*****************");

            // POP
            yıgın.Pop();
            Console.WriteLine();
            Console.WriteLine("Kaç tane: " + yıgın.Count());
            Console.WriteLine("Peek degeri: " + yıgın.Peek()); // en üsttekini gösterir.

            //COUNT
            Console.WriteLine();
            Console.WriteLine("Kaç tane: " +yıgın.Count());

            //CLEAR
            yıgın.Clear();
            Console.WriteLine();
            Console.WriteLine("Kaç tane sildikten sonra: " + yıgın.Count());


            Console.ReadLine();

        }
    }
}
