using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.DTO;

public class LoginDTO
{
    [Required]
    [EmailAddress]
    [MaxLength(255)]
    public string Email { get; set; }
    
    [Required]
    [PasswordPropertyText]
    [MaxLength(255)]
    public string Password { get; set; }
}