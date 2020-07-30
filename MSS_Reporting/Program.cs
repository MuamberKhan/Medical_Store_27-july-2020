using Medical_Store_System;
using System;
using System.Windows.Forms;

namespace MSS_Reporting
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
            Application.Run(new ReportPrompt());

        }
    }
}
