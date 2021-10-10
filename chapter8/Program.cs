using Chapter5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter8
{
    static class Program
    {
        public static FormAdd formAdd = new FormAdd();
        public static FormDelete formDelete = new FormDelete();
        public static FormSearchCost formSearchCost = new FormSearchCost();
        public static FormSearchNum formSearchNum = new FormSearchNum();
        public static FormSearchCustomer formSearchCustomer = new FormSearchCustomer();
        public static FormSearchGood formSearchGood = new FormSearchGood();
        public static FormChange formChange = new FormChange();
        public static OrderService service = new OrderService();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(formAdd);
        }
    }
}
