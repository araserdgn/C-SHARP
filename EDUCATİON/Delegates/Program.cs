using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void Mydelegate2(string text);
    public delegate int Mydelegate3(int no1,int no2);
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
            //customer.SendMessage();
            //customer.ShowAlert();

            MyDelegate mydelegate = customer.SendMessage; // SendMessage elçisi oldu
            mydelegate += customer.ShowAlert; // Send ve Show metdoların elçisi oldu

            Mydelegate2 mydelegate2 = customer.SendMessage2; // parametre alan tarzda yaptık
            mydelegate2+=customer.ShowAlert2;
            mydelegate2-=customer.ShowAlert2; // burda da show olanı çıakrttık

            Mydelegate3 mydelegate3 = customer.SendMessage3;
            mydelegate3 += customer.ShowAlert3;

            Console.WriteLine(mydelegate3(5,6)); // ekrana son verilen metodu yazar
                                                // aynı anda iki sonucu da yazmayacak İNT seklinde olanda

            mydelegate2("selamun aleykum");

            mydelegate();  // yazdı ekrana

            Console.WriteLine("************"); 

            Func<int, int, int> add = topla; // Func delegatesi , ilk 2 int topla metoddaki parametre
                                            // en sondaki ise döndiğindeki tipi gösterir

            Console.WriteLine(add(100,20));

            Func<int> getRandomNumber = delegate // getRandom'u delegate etim
            {
                Random rand = new Random();
                return rand.Next(5,120);
            };
            Console.WriteLine(getRandomNumber());

            Func<int> getrandom =()=> new Random().Next(1,20); // Func baska bir sekilde gösterimi

            Thread.Sleep(500); // 500 milisaniye bekletiyoruz kodu sonra asagıdan deva mediyo

            Console.WriteLine(getrandom());

            Console.ReadLine();

        }

        static int topla(int a,int b) { 
            return a + b;
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string message)
        {
            Console.WriteLine(message);
        }

        public int SendMessage3(int a,int b)
        {
            return a+b;
        }
        public int ShowAlert3(int a,int b)
        {
            return a * b;
        }
    }
}
