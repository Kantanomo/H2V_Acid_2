using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2V_Acid_2
{
    static class Program
    {
        public static MemoryHandler Memory;
        public static Random Random = new Random();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Process.GetProcessesByName("halo2").Length == 0)
            {
                MessageBox.Show("Halo 2 is not running, please start the game before running this program.", "Uh-oh!");
                Process.GetCurrentProcess().Kill();
            }
            Memory = new MemoryHandler(Process.GetProcessesByName("halo2")[0]);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Wowzers());
        }
    }
}
