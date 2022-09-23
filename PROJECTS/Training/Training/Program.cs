using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle(5,6);
            
            Console.WriteLine("Alan= "+rectangle.area());
            Console.WriteLine("Çevre= "+rectangle.perimeter());


            Console.ReadLine();
        }
    }
     
    class Rectangle
    {
        public int weight;
        public int height;
        int çevre = 0;

        public Rectangle(int k,int u)
        {
            this.weight = k;
            this.height = u;
        }

        public int area()
        {
            return çevre = weight * height;
            
        }

        public int perimeter()
        {
            return çevre = 2*(weight + height);

        }
    }
   
}
