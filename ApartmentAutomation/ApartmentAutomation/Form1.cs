﻿using System;
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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Incomes_Click(object sender, EventArgs e)
        {
            new Incomes().Show();
        }

        private void btn_Expences_Click(object sender, EventArgs e)
        {
            new Expenses().Show();
        }
    }
}
