using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project_New

{
    internal static class Launcher
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] Args)
        {
            Program program = new Program();
            program.startProgram();
        }
    }
}
