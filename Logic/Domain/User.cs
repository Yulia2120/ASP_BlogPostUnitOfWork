using System.ComponentModel.DataAnnotations;

namespace Logic.Domain
{
    public class User
    {
        public int Id { get; set; }
        [Required, StringLength(90)]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        public EnumRole EnumRole { get; set; }


    }
}
