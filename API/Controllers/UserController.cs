using API.Request;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.DTO.User;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace API.Controllers;
[Controller]
[Route("api/v1/users")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UserController(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    [HttpPost]
    [Route("register")]
    public async Task<IActionResult> Register([FromBody] RegisterUser registerUser)
    {
        try
        {
            UserDTO userDto = _mapper.Map<UserDTO>(registerUser);

            await _userService.Create(userDto);

            return Created("Usuario Cadastrado com sucesso", userDto);
        }
        catch(Exception)
        {
            return StatusCode(500);
        }
    }

    [HttpPut]
    [Route("/update")]
    public async Task<IActionResult> Update([FromBody] UpdateUser updateUser)
    {
        try
        {
            UserDTO userDto = _mapper.Map<UserDTO>(updateUser);

            var userUpdated = _userService.Update(userDto);

            return Ok("Usuario atualizado com sucesso");
        }
        catch(Exception)
        {
            return StatusCode(500);
        }
    }

    [HttpGet]
    [Route("/findall")]
    public async Task<IActionResult> Get()
    {
        try
        {
            await _userService.Get();

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest("Nao ha usuarios cadastrados no banco de dados");
            
        }
    }

    [Authorize]
    [HttpGet]
    [Route("/{id}")]
    public async Task<IActionResult> Get(int id)
    {
        
    }
}