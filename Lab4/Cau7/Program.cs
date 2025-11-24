using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Cau7
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Cau7.DatabaseFunction.InitializeDatabase();
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Bai7());
        }
    }
}
