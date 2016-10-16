using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Real_estate_business_automation.Entities;
using Real_estate_business_automation.Repositories;
using System.Configuration;
using Real_estate_business_automation.Controllers;

namespace Real_estate_business_automation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Controller.Initialize (ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            Application.Run(new Login());
            if (Controller.CurrentUser == null)
            {
                return;
            }

            Application.Run(new Form1());
        }
    }
}
