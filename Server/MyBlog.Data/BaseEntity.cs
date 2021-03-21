using System;

namespace MyBlog.Data
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
