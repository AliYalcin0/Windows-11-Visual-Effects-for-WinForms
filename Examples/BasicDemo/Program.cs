using System;
using System.Windows.Forms;
using Windows11Effects.Examples;

namespace Windows11Effects.Demo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Check Windows version and show appropriate demo
            if (Win11Effects.Fluent.Windows11Effects.IsWindows11OrGreater())
            {
                Application.Run(new AdvancedExampleForm());
            }
            else
            {
                Application.Run(new BasicExampleForm());
            }
        }
    }
}
