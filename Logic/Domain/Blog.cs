using System.ComponentModel.DataAnnotations;

namespace Logic.Domain
{
    public class Blog : Identity
    {
          
            [StringLength(250)]
           public string Url { get; set; } = string.Empty;

           public  List<Post>? Posts { get; set; }
        

    }
}
