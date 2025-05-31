using System.ComponentModel.DataAnnotations;

namespace application2.Models.DTO
{
    public class RegisterRequestDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public String UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //roles
        public string[] Roles { get; set; }
    }
}
