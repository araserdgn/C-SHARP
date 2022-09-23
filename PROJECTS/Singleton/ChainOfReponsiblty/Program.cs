using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfReponsiblty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            VicePresident vicePresident = new VicePresident();
            President president = new President();

            manager.SetSuccesor(vicePresident);
            vicePresident.SetSuccesor(president);

            Expense expense = new Expense { Detail ="training",Amount=110}; 
            manager.HandleExpense(expense);

            Console.ReadLine();


        }
    }
    public class Expense
    {
        public string Detail { get; set; }
        public decimal Amount { get; set; }
    }
    abstract class ExpenseHandlerBase //**

    {
        protected ExpenseHandlerBase _succesor;
        public abstract void HandleExpense(Expense expense);
        public void SetSuccesor (ExpenseHandlerBase succesor)
        {
            _succesor = succesor;
        }
    }
    class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount <= 100) // 100TL altındayse
            {
                Console.WriteLine("Manager handler the expense.!");
            }
            else if(_succesor != null)
            {
                _succesor.HandleExpense(expense);
            }
        }
    }
    class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if ( expense.Amount >100 && expense.Amount <=1000) // 100TL altındayse
            {
                Console.WriteLine("Vice PResident handler the expense.!");
            }
            else if (_succesor != null)
            {
                _succesor.HandleExpense(expense);
            }
        }
    }
    class President : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 1000) // 100TL altındayse
            {
                Console.WriteLine("President handler the expense.!");
            }
            
        }
    }
}
