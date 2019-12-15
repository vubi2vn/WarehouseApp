using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinNC
{
    static class Program
    {

        public static FrmMain mainForm = null;
        public static frmLogin loginForm = null;
        public static frmConfiguration cauhinhfrm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
            loginForm = new frmLogin();
            Application.Run(loginForm);
        }
    }
}
