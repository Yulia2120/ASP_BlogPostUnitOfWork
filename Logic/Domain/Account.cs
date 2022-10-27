using System.ComponentModel.DataAnnotations;

namespace Logic.Domain
{
    public class Account: Identity
    {
        [Required, StringLength(90)]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        public EnumRole EnumRole { get; set; }
        public List <Post>? Posts { get; set; }

       

    }
}
