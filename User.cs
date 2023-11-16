using System;

namespace Software_Engineering_Project_New
{
    public class User
    {

        public User(int pId, 
                    string pName,
                    string pEmail,
                    string pContactNumber,
                    string pUsername, 
                    int? pManagerId, 
                    int? pRoleId, 
                    int pisAdmin)
        {
            Id = pId;
            Name = pName;
            Email = pEmail;
            ContactNumber = pContactNumber;
            Username = pUsername;
            ManagerId = pManagerId;
            RoleId = pRoleId;
            isAdmin = pisAdmin;
        }


        public int Id { get; }

        public string Name { get; }
        
        public string Email { get; }

        public string ContactNumber { get; }

        public string Username { get; }

        public int? ManagerId { get; }

        public int? RoleId { get; }
        public int isAdmin { get; }  
    }
}