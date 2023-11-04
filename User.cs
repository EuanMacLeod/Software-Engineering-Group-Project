namespace Software_Engineering_Project_New
{
    internal class User
    {

        public User(int pID, string pName, string pEmail, string pContactNumber, string pUsername, int? pRoleID,
            int? pManagerID)
        {
            ID = pID;
            Name = pName;
            Email = pEmail;
            ContactNumber = pContactNumber;
            Username = pUsername;
            RoleID = pRoleID;
            ManagerID = pManagerID;
        }


        public int ID { get; set; }

        public string Name // property
        {
            get;
            // get method
            set;
            // set method
        }
        
        public string Email { get; set; }

        public string ContactNumber { get; set; }

        public string Username { get; set; }

        public int? RoleID { get; set; }

        public int? ManagerID { get; set; }
    }
}