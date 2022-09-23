using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsodan sonra gelen yetkililerin derecesi : ");


            Employee iso = new Employee { Name = "İsmail Erdoğan" };
            Employee irem = new Employee { Name = "İrem Komur" };

            iso.AddSubordinate(irem); // İso nun altçalışanı İrem

            Contractor emin = new Contractor { Name = "Emin Ekerbiçer" };
            irem.AddSubordinate(emin);


            Employee Sule = new Employee { Name = "Sule Sengul" };
            iso.AddSubordinate(Sule);

            Employee Seher = new Employee { Name = "Seher Yılmaz" };
            Sule.AddSubordinate(Seher); // Sulenin alt calısanı seher

            // BUNLARI EKRANA YAZALIM
            Console.WriteLine("İSO");
            foreach (Employee manager in iso) // isonun alt calısanlarını yaz
            {
                Console.WriteLine("  {0}",manager.Name);
                foreach (IPerson employe in manager) // manager in içinde dolan
                {
                    Console.WriteLine("    {0}",employe.Name);
                }
            }

            Console.ReadLine();
        }
    }
    interface IPerson // Kişilerde olması gereken ortak seyler
    {
        string Name { get; set; }
    }
    class Contractor : IPerson
    {
        public string Name { get; set; }
    }
    class Employee : IPerson, IEnumerable<IPerson> // sondaki kısım gezecek kısımdır
    {
        List<IPerson> _subordinates = new List<IPerson>();

        public void AddSubordinate (IPerson person)
        {
            _subordinates.Add (person);
        }
        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }
        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }
        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var sub in _subordinates)
            {
                yield return sub;
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
