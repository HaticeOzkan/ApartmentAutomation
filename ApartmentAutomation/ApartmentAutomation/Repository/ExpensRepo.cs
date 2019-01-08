using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation
{
    class ExpensRepo
    {
        public List<Expense> List { get; set; }
        public ExpensRepo()
        {
            List = new List<Expense>();
        }
       
        public List<Expense> GetExpense()
        {
            List.Clear();
            DataTable dt = Program.SqlHelper.GetData("Select * from tbl_Expens");
            foreach (DataRow item in dt.Rows)
            {
                Expense Expense = new Expense();
                Expense.Amount = (decimal)item["Amount"];
                Expense.Date = (DateTime)item["Date"];
                Expense.ExpenseName =(ExpenseTypeID) item["ExpenseTypeID"];
                Expense.ExpenseID = (int)item["ExpenseID"];
                List.Add(Expense);
            }
            return List;
        }
        public void SendToDatabase(Expense Expense)
        {
            SqlParameter p1 = new SqlParameter("Date",Expense.Date);
            SqlParameter p2 = new SqlParameter("Amount", Expense.Amount);
            SqlParameter p3 = new SqlParameter("ExpenseTypeID", Expense.ExpenseName);
            SqlParameter p4 = new SqlParameter("ExpenseID", Expense.ExpenseID);
            Program.SqlHelper.ExecuteProcedure("SaveExpense", p1, p2, p3,p4);
        }
    }
}
