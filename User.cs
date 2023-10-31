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
        private int? roleID;
        private int? managerID; //nullable


        public User(string pName, string pEmail, string pContactNumber,  string pUsername, int? pRoleID, int? pManagerID)
        {
            this.name = pName;
            this.email = pEmail;
            this.contactNumber = pContactNumber;
            this.username = pUsername;
            this.roleID = pRoleID;
            this.managerID = pManagerID;

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

        public int? RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }

        public int? ManagerID
        {
            get { return managerID; }
            set {  managerID = value; }

        }




    }
}
