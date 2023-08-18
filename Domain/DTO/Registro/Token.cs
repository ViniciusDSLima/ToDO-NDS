using Domain.DTO.User;

namespace Domain.DTO;

public class Token
{
    public string AcessToken { get; set; }
    public double ExpiresIn { get; set; }
    public UserDTO User { get; set; }
}