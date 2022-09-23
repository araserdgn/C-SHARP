using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheretanceKALITIM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "İso"; 

            Student[] students = new Student[2]
            {
                new Student{FirstName="İso"}, 
                new Student{FirstName="Reus Bey"}
            };

            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName);
            }

            Console.ReadLine(); 
        }

        class Person
        {
            public string FirstName { get; set; }
            public int LastName { get; set; }
            public string ID { get; set; }
        }

        class Customer:Person // yani Customer senin baban Person diyor, o yüzden Personun özellikleri alır. KALITIM bu işte
        {
            public int ICity { get; set; } // kendin de eklersin
        }

        class Student:Person
        {
            public int Code { get; set; }
        }
    }
}
