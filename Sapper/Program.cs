using System;
using System.Windows.Forms;

namespace Sapper
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Sapper form2 = new Sapper();
            Application.Run(form2);
        }
    }
}
