namespace Software_Engineering_Project_New
{
    internal class User
    {
        private string contactNumber;
        private int id;


        public User(int pID, string pName, string pEmail, string pContactNumber, string pUsername, int? pRoleID,
            int? pManagerID)
        {
            id = pID;
            Name = pName;
            Email = pEmail;
            contactNumber = pContactNumber;
            Username = pUsername;
            RoleID = pRoleID;
            ManagerID = pManagerID;
        }


        public string Name // property
        {
            get;
            // get method
            set;
            // set method
        }

        public string Email { get; set; }

        public string Username { get; set; }

        public int? RoleID { get; set; }

        public int? ManagerID { get; set; }
    }
}