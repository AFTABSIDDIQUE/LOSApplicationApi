namespace LOSApplicationApi.Model
{
    public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public byte IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
