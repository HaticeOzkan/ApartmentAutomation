using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation
{
    class Operation
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
    class Income : Operation
    {
        public int FlatNo {get; set; }
    }
   class Expense : Operation
    {
        public ExpenseTypeID ExpenseName { get; set; }
        public int ExpenseID { get; set; }
       
    }
    enum ExpenseTypeID
    {
        Water,
        Electric,
        Cleanliness,
        Elevator
    }
    
}
