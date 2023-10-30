using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project_New

{
    internal class Program
    {


        private User user;


        public void startProgram()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HomePage());

            new HomePage().Show();
            Application.Run();



        }




        //test comment Euan
    }
}