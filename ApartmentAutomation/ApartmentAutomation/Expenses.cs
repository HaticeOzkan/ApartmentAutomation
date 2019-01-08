using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentAutomation
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            dataGrdViewExpense.DataSource = null;
            dataGrdViewExpense.DataSource= Program.ExpensRepo.GetExpense();
            comboBoxMounthGetir();
        }

        private void comboBoxMounthGetir()
        {
            foreach (var item in Enum.GetValues(typeof(Mounths)))
            {
                comboBoxMounth.Items.Add(item);
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Expense Expense = new Expense();
            Expense.Amount =Convert.ToInt32(textBoxAmount.Text);
            Expense.Date = Convert.ToDateTime(dateTimePickerExpense.Text);
            Expense.ExpenseName =SelectedExpenseType();
            Expense.ExpenseID= (int)SelectedExpenseType();
            Program.ExpensRepo.SendToDatabase(Expense);
            Expenses_Load(sender, e);
        }

        private ExpenseTypeID SelectedExpenseType()
        {

            if (radioButtonCleanLines.Checked == true)
                return ExpenseTypeID.Cleanliness;
            else if (radioButtonElectric.Checked == true)
                return ExpenseTypeID.Electric;
            else if (radioButtonWater.Checked == true)
                return ExpenseTypeID.Water;
            else
               return ExpenseTypeID.Elevator;
        }

        private void buttonWatch_Click(object sender, EventArgs e)
        {
            //List<Expense> List = Program.ExpensRepo.GetExpense();
            //var Filter = List.Where(x =>x.Date.ToString("MM") ==(comboBoxMounth.SelectedValue).ToString()).ToList();
            //dataGrdViewExpense.DataSource = null;
            //dataGrdViewExpense.DataSource = Filter;
        }
    }
}
