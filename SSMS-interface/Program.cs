using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSMS_interface
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        class MyApplicationContext : ApplicationContext
        {
            public MyApplicationContext()
            {
                Form form1 = new log_in();
                form1.Show();
            }
        }
        [STAThread]
        static void Main()
        {
            MyApplicationContext context = new MyApplicationContext();
          //  Application.EnableVisualStyles();
          //  Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new log_in());
            Application.Run(context);
        }

    }
}
