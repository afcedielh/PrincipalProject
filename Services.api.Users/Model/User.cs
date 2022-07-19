namespace Services.api.Users.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string? Email { get; set; }
        public string? Pass { get; set; }
        public string? UserName { get; set; }
        public string? Name { get; set; }
    }
}
