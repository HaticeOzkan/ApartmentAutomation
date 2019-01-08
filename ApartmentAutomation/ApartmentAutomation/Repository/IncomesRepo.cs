using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation
{
    class IncomesRepo
    {
        public List<Income> List { get; set; }
        public IncomesRepo()
        {
            List = new List<Income>();
        }
       public List<Income> GetIncomes()
        {
            List.Clear();
            DataTable dt = Program.SqlHelper.GetData("Select * from tbl_Incomes");
            foreach (DataRow item in dt.Rows)
            {
                Income Income = new Income();
                Income.Amount =(decimal) item["Amount"];
                Income.Date =(DateTime)item["Date"];
                Income.FlatNo = (int)item["FlatNo"];
                List.Add(Income);
            }
            return List;
        }
        public void SendToDatabase(Income Income)
        {
            SqlParameter p1 = new SqlParameter("Date",Income.Date);
            SqlParameter p2 = new SqlParameter("Amount", Income.Amount);
            SqlParameter p3 = new SqlParameter("FlatNo", Income.FlatNo);
            Program.SqlHelper.ExecuteProcedure("SaveIncome", p1, p2, p3);

        }
        
    }
}
