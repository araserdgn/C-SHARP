using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new OracleServer();
            dataBase.Add();
            dataBase.Delete();

            DataBase dataBase2 = new SqlServer();
            dataBase2.Add();
            dataBase2.Delete();

            Console.ReadLine();
        }

        abstract class DataBase
        {
            public void Add() // bu her yerde aynıdııır.
            {                   // Tamamlanmış kısım
                Console.WriteLine("Added by.");
            }
            public abstract void Delete(); // ama bu farklılık gösterebilir.
                                            // tamamlanmamış , her veritabanda farklı oalcak kısım.
        }

        class SqlServer : DataBase
        {
            public override void Delete() // DELETE geldi , çnk farklı olan bu Add hepsinde ortak.
            {
                Console.WriteLine("Delete by SqlServer.");
            }
        }

        class OracleServer : DataBase
        {
            public override void Delete()
            {
                Console.WriteLine("Delete by OracleServer.");
            }
        }
    }
}
