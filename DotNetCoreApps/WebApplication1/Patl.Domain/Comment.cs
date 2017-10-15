using System;

namespace Patl.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public string Author { get; set; }
    }
}
