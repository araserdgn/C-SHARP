using System;

namespace İnterface
{
    class Program
    {
        static void Main ()
        {
            PersonManege manege = new PersonManege ();
            manege.Add(new Customer { FırstName="iso",ID=154651});

            //  manege.Add (new Student { }) --> bu sekilde izin vermez
            // Çnk ben PersonManege de parametre olarak Customer istedim
            // Fakat PersonManegede parametre Iperson istersem Student de Customer de çagırblm.

            /*manege.Add(new Student { FırstName = "Ceyda", ID = 6979 });

            CustomerManager manager = new CustomerManager ();
            manager.Add(new OracleServerCustomerDal()); */

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new OracleServerCustomerDal(),
                new SqlServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


            


            Console.ReadLine ();    
        }


        interface IPerson
        {
            int ID { get; set; }
            string FırstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int ID { get; set; }
            public string FırstName { get ; set ; }
            public string LastName { get; set ; }

            public string Adress { get; set; }  // interface dısında biz de ekleyebilirz böyle 
        }

        class Student:IPerson
        {
            public int ID { get; set; }
            public string FırstName { get; set; }
            public string LastName { get; set; }

            public string Departmend { get; set; } 
        }
        
        class PersonManege
        {
            public void Add (IPerson person) // Customer sınıfınından customer tanımlama istedk
            {
                Console.WriteLine(person.FırstName);
                Console.WriteLine(person.ID);
            }   
        }
            
     }
}