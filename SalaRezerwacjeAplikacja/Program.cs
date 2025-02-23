using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SalaRezerwacjeAplikacja;
using SalaRezerwacjeAplikacja.Data;

namespace SalaRezerwacjeAplikacja
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            

            ApplicationConfiguration.Initialize();
            using (var db = new AppDbContext())

            {
                
                db.Database.Migrate();
            }

            Application.Run(new MainForm());
        }
    }
}
