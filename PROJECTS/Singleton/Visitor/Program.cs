using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager aras = new Manager { Name="Aras", Salary=15000};
            Manager sule = new Manager { Name = "Şule", Salary = 12000 };

            Worker calısan1 = new Worker { Name="Buse",Salary=500};
            Worker calısan2 = new Worker { Name = "Emin", Salary = 500 };

            aras.Subordinates.Add(sule);
            sule.Subordinates.Add(calısan1);
            sule.Subordinates.Add(calısan2);

            OrganisationStructure organisationStructure = new OrganisationStructure(aras);

            PayRollVisitor payRollVisitor = new PayRollVisitor();
            Payirise payrise = new Payirise();
            
            organisationStructure.Accept(payrise);
            organisationStructure.Accept(payRollVisitor);

            Console.ReadLine();
        }
    }

    class OrganisationStructure
    {
        public EmployeeBase Employee;
        public OrganisationStructure(EmployeeBase Firstemployee)
        {
            Employee = Firstemployee;
        }
        public void Accept(VisitorBase visitor)
        {
            Employee.Accept(visitor);
        }
    }
    abstract class EmployeeBase
    {
        public abstract void Accept(VisitorBase visitor);
        public string Name { get; set; }
        public decimal Salary { get; set; }
       
    }
     class Manager : EmployeeBase
    {
        public Manager()
        {
            Subordinates = new List<EmployeeBase>();
        }
       public List<EmployeeBase> Subordinates { get; set; }
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);

            foreach (var employee in Subordinates)
            {
                employee.Accept(visitor);
            }
        }
    }
    class Worker : EmployeeBase
    {
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
   abstract class VisitorBase // butun personel için maas ile ilgili maaş artıs azalıs kısmı
    {                               // abstrack oldu ki override yapıp değişsin aynı isimde olan VİSİT
        public abstract void Visit(Worker worker);
        public abstract void Visit(Manager manager);
    }
    class PayRollVisitor : VisitorBase // maas kısmı
    {

        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} paid {1}",worker.Name,worker.Salary);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} paid {1}", manager.Name, manager.Salary);
        }
    }
    class Payirise : VisitorBase // maaşa zam kısmı
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} salary increased to {1}", worker.Name, worker.Salary/(decimal)1.2);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} salary increased {1}", manager.Name, manager.Salary/(decimal)1.5);
        }
    }

}
