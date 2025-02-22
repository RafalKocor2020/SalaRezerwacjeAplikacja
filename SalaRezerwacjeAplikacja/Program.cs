using System;
using System.Windows.Forms;
using SalaRezerwacjeAplikacja;

namespace SalaRezerwacjeAplikacja
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
