
using System.ComponentModel.DataAnnotations;

namespace Logic.Domain
{
    public class Post :Identity
    {
        [StringLength(250)]
        public string Title { get; set; }= string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime PostedOn { get; set; }

        
        //public int UserId { get; set; }
        //public User? User { get; set; }
        //public int BlogId { get; set; }
        //public Blog? Blog { get; set; }


    }
}
