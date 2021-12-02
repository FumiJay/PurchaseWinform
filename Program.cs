using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseWinform
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.Yes)
            {
                Application.Run(new PurchaseList());
            }
            else 
            {
                return;
            }
        }
    }
}
