namespace JWT_CQRS.Core.Domain
{
    public class User
    {
        public User()
        {
            Role = new Role();
        }

        public int Id { get; set; }
        public int RoleId { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public Role Role { get; set; }
    }
}
