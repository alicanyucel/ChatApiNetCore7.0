using System.ComponentModel.DataAnnotations;

namespace ChatApi.Dtos
{
    public class UserDto
    {
        [Required]
        [StringLength(18,MinimumLength =3,ErrorMessage ="name must be at least(2),and minimum (1) characters ")]
        public string Name { get; set; }
    }
}
