using System;

namespace Software_Engineering_Project_New

{
    internal static class Launcher
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] Args)
        {
            Program program = new Program();
            program.startProgram();
        }
    }
}