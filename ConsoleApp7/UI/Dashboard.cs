using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.UI
{
    class Dashboard
    {
        public void ShowDashboard()
        {
            //ManageDeparment manageDeparment = new ManageDeparment();
            //manageDeparment.Run();

            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.Run();
        }
    }
}
