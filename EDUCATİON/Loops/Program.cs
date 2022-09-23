using System;
using System.Text;
using System.Threading.Tasks;


namespace Loops
{
    class Program
    {
        static void Main ()
        {
            //NewMethod();
            var number = 10;
            Console.WriteLine("While döngüsü.");
            

            // number = While(number);
            Console.WriteLine("Do-while döngüsü");
            // number = DoWhile(number);

            string[] students = { "İsmail", "Kübra", "Ezgi", "Emin" };

            //Foreach(students);

            if (AsalSayı(10))
            {
                Console.WriteLine("This is ASAL number.");
            }
            else
            {
                Console.WriteLine("This is NOT ASAL number.");
            }


            Console.ReadLine();
        }
        private static bool AsalSayı(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
                
            }
            return result;
        }
        private static void Foreach(string[] students)
        {
            foreach (var student in students) // students dizisi içinde STUDENT yaptı , bunları birim gibi düşündü yani
            {
                Console.WriteLine(student);
            }
        }

        private static int DoWhile(int number)
        {
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number > 0);
            return number;
        }

        private static int While(int number)
        {
            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }

            return number;
        }

        private static void NewMethod()
        {
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        
    }
 }

