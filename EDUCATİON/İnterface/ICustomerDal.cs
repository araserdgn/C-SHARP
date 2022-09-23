using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Add SQL great.");
        }

        public void Delete()
        {
            Console.WriteLine("Add SQL great.");
        }

        public void Update()
        {
            Console.WriteLine("Add SQL great.");
        }
    }

    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Add ORACLE great.");
        }

        public void Delete()
        {
            Console.WriteLine("Delete ORACLE great.");
        }

        public void Update()
        {
            Console.WriteLine("Update ORACLE great.");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }

}
