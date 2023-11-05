namespace Software_Engineering_Project_New
{
    internal class User
    {

        public User(int pId, string pName, string pEmail, string pContactNumber, string pUsername, int? pRoleId,
            int? pManagerId)
        {
            Id = pId;
            Name = pName;
            Email = pEmail;
            ContactNumber = pContactNumber;
            Username = pUsername;
            RoleId = pRoleId;
            ManagerId = pManagerId;
        }


        public int Id { get; set; }

        public string Name { get; }
        
        public string Email { get; }

        public string ContactNumber { get; }

        public string Username { get; }

        public int? RoleId { get; }

        public int? ManagerId { get; }
    }
}