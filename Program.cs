using System;
using System.Windows.Forms;

namespace Software_Engineering_Project_New

{
    internal class Program
    {
        public void startProgram()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HomePage());

            //new HomePage().Show();
            new LoginPage().Show();
            Application.Run();
            Console.WriteLine("Bye Bye");
        }


        //test comment Euan
    }
}