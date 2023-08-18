using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace API.Request;

public class UpdateUser
{
    [Required(ErrorMessage = "É necessario o Id do cliente para que possamos identificar no banco de dados")]
    public int Id { get; set; }
    
    [MinLength(3, ErrorMessage = "O Nome tem no minimo 3 caracteres")]
    [MaxLength(20, ErrorMessage = "O Nome tem ao maximo 20 caracteres")]
    public string Nome { get; set; }
    
    [EmailAddress]
    [MinLength(15, ErrorMessage = "O Email tem no minino 15 caracteres")]
    [MaxLength(50, ErrorMessage = "O Email tem ao maximo 50 caracteres")]
    public string Email { get; set; }
    
    [MinLength(8, ErrorMessage = "O Email tem no minino 8 caracteres")]
    [MaxLength(20, ErrorMessage = "O Email tem ao maximo 20 caracteres")]
    public string Password { get; set; }
    
    
    
}