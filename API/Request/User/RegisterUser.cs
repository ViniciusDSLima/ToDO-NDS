using System.ComponentModel.DataAnnotations;

namespace API.Request;

public class RegisterUser
{
    [Required(ErrorMessage = "O Nome é obrigatorio")]
    [MinLength(3, ErrorMessage = "O Nome deve ter pelo menos 3 caracteres")]
    [MaxLength(20, ErrorMessage = "O Nome deve ter ao maximo 20 caracteres")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "O Email é obrigatorio")]
    [MinLength(15, ErrorMessage = "O Email deve ter pelo menos 3 caracteres")]
    [MaxLength(50, ErrorMessage = "O Email deve ter ao maximo 50 caracteres")]
    [RegularExpression(
        @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "A Senha é obrigatorio")]
    [MinLength(8, ErrorMessage = "A Senha deve ter pelo menos 8 caracteres")]
    [MaxLength(20, ErrorMessage = "A Senha deve ter ao maximo 50 caracteres")]
    public string Senha { get; set; }
}