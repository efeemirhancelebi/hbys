using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBYS
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
            girisFormu giris = new girisFormu();

            if (giris.ShowDialog() == DialogResult.OK)
            {
                Application.Run(giris.AnaForm); // Ana form olarak doğru form burada çalıştırılacak
            }
        }
    }
}
