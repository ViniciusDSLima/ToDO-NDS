using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.DTO;

public class RegisterDTO
{
    [Required]
    [MaxLength(255)]
    public string Name { get; set; }
    
    [Required]
    [EmailAddress]
    [MaxLength(255)]
    public string Email { get; set; }
    
    [Required]
    [PasswordPropertyText]
    [MaxLength(255)]
    public string Password { get; set; }
    
    [Required]
    [Compare("Password")]
    public string PasswordValidation { get; set; }
}