
using System.ComponentModel.DataAnnotations;

namespace Logic.Domain
{
    public class Post :Identity
    {
        [StringLength(250)]
        public string Title { get; set; }= string.Empty;
        public string Content { get; set; } = string.Empty;
        //public DateTime PostedOn { get; set; }



    }
}
