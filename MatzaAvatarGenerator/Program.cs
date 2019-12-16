using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MatzaAvatarGenerator
{
    static class Program
    {
        public static bool IsRunning = false;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
