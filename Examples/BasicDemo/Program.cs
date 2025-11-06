using System;
using System.Windows.Forms;

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
            if (Windows11Effects.IsWindows11OrGreater())
            {
                Application.Run(new AdvancedExampleForm());
            }
            else
            {
                Application.Run(new BasicExampleForm());
            }
        }
    }
)
