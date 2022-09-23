using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlSErver sqlSErver = new SqlSErver();
            sqlSErver.Add();

            MySql mysql = new MySql();
            mysql.Add();

            Console.ReadLine(); 
        }

        class DataBase {

            public virtual void Add() // VİRTUAL yazdıgında isted. sınıfa gidip DataBase içindekini değiştireblrsn. Buna olanak saglar
            {
                Console.WriteLine("Added by default.");
            }

            public virtual void Delete() // VİRTUAL yazdıgında isted. sınıfa gidip DataBase içindekini değiştireblrsn. Buna olanak saglar
            {
                Console.WriteLine("Delete by default.");
            }
        }

        class SqlSErver:DataBase
        {
            public override void Add() // OVERRİDE Sql için yazımı değiştirmeyi sağladı
            {
                Console.WriteLine("Sql is Added.");
               // base.Add(); //BUNU aktif edersen DataBasenin de Add kısmını aktif ediyo
            }
        }

        class MySql:DataBase
        {

        }
    }
}
