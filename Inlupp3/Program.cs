using System;
using System.Windows.Forms;

// Mikaela Eriksson mikerv-0 9410122163 L0002B task 3

namespace Inlupp3
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
            Application.Run(new Form1());
        }
    }
}
