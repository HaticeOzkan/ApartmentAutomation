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
    public partial class Incomes : Form
    {
        public Incomes()
        {
            InitializeComponent();
        }

        private void Incomes_Load(object sender, EventArgs e)
        {           
            dataGridViewIncomes.DataSource = null;
            dataGridViewIncomes.DataSource = Program.IncomesRepo.GetIncomes();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Income Income = new Income();
            Income.Amount =Convert.ToInt32(txtBx_Amount.Text);
            Income.Date = DateTime.Today;
            Income.FlatNo =(int) numericUpDownFlatNo.Value;
            Program.IncomesRepo.SendToDatabase(Income);
            Incomes_Load(sender, e);
        }
    }
}
