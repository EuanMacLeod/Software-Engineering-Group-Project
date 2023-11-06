namespace Software_Engineering_Project_New
{
    internal class User
    {

        public User(int pId, string pName, string pEmail, string pContactNumber, string pUsername, int? pManagerId, int? pRoleId)
        {
            Id = pId;
            Name = pName;
            Email = pEmail;
            ContactNumber = pContactNumber;
            Username = pUsername;
            ManagerId = pManagerId;
            RoleId = pRoleId;
        }


        public int Id { get; }

        public string Name { get; }
        
        public string Email { get; }

        public string ContactNumber { get; }

        public string Username { get; }

        public int? ManagerId { get; }

        public int? RoleId { get; }
    }
}