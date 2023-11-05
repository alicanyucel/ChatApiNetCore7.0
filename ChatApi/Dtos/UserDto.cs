using System.ComponentModel.DataAnnotations;

namespace ChatApi.Dtos
{
    public class UserDto
    {
        [Required]
        [StringLength(15,MinimumLength=3,ErrorMessage ="name must be at least{1},and maximum{2} characters ")]
        public string Name { get; set; }
    }
}
