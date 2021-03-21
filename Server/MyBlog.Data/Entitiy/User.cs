namespace MyBlog.Data
{
    public class User : BaseEntity
    {
        public string Account { get; set; }
        public string Email { get; set; }
        public byte[]? Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
