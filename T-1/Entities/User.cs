namespace T_1.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; }
        public string RefleshToken { get; set; }
        public DateTime ExpiredTime { get; set; }
        public Role Role { get; set; }

    }
}