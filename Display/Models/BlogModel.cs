using System.Collections.Generic;

namespace Display.Models
{
    public class BlogModel
    {
        public IEnumerable<Post> Posts { get; set; }
		public int Count { get; set; }
        public SidebarModel Sidebar { get; set; }
    }
}