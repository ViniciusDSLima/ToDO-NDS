using Domain.DTO;
using Domain.DTO.User;
using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IUserService
{
    Task<UserDTO> Create(UserDTO userDto);
    Task<Token> Update(UserDTO userDto);
    Task Remove(int id);
    Task<UserDTO> Get(int id);
    Task<List<UserDTO>> Get();
    Task<List<UserDTO>> SeachByName(string name);
    Task<List<UserDTO>> SeachByEmail(string email);
    Task<UserDTO> GetByEmail(string email);

}