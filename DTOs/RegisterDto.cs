using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]//驗證器 比如最大長度 必填等等
        public required string Username { get; set; }
        [Required]
        public required string Password { get; set; }
    }
}