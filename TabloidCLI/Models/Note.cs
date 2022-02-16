using System;

namespace TabloidCLI.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public string Content { get; set; }
        public Post Post { get; set; }
    }
}
