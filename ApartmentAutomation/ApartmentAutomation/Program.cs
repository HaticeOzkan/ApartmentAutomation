﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentAutomation
{
    static class Program
    {
      public static  SqlHelper SqlHelper = new SqlHelper();
        public static ExpensRepo ExpensRepo = new ExpensRepo();
        public static IncomesRepo IncomesRepo = new IncomesRepo();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
       
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
