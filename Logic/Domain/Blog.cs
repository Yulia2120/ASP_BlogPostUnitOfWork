using System.ComponentModel.DataAnnotations;

namespace Logic.Domain
{
    public class Blog
    {
            public int BlogId { get; set; }
            [StringLength(250)]
           public string Url { get; set; } = string.Empty;

           public virtual List<Post>? Posts { get; set; }
        

    }
}
