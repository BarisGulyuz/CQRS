namespace JWT_CQRS.Core.Domain
{
    public class Role
    {
        public Role()
        {
            Users = new List<User>();
        }
        public int Id { get; set; }
        public string RoleName { get; set; } = String.Empty;
        public List<User> Users { get; set; }

    }
}
