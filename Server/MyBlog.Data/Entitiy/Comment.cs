namespace MyBlog.Data
{
    public class Comment : BaseEntity
    {
        public int PostId { get; set; }
        public string Content { get; set; }
        public int ReplyToId { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
