namespace MyBlog.Data
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool? Visibility { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
