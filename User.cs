using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Software_Engineering_Project_New
{
    internal class User
    {
        private String name;
        private String email;
        private String username;
        private String contactNumber;
        private int role;
        private int? managerID; //nullable

        public User(string pName, string pEmail,string pContactNumber, int pRole)
        {
            Initialise(pName, pEmail, pContactNumber, pRole);
        }
        public User(string pName, string pEmail, string pContactNumber, int pRole, int pManagerID)
        {
            Initialise(pName, pEmail, pContactNumber, pRole);
            this.managerID = pManagerID;

        }

        private void Initialise(string pName, string pEmail, string pContactNumber, int pRole)
        {
            this.name = pName;
            this.email = pEmail;
            this.username = pContactNumber;
            this.contactNumber = pContactNumber;
        }

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public int Role
        {
            get { return role; }
            set { role = value; }
        }

        public int? ManagerID
        {
            get { return managerID; }
            set {  managerID = value; }

        }




    }
}
