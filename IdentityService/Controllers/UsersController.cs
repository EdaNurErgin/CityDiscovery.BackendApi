using IdentityService.Application.DTOs.Users;
using IdentityService.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Common.DTOs.Identity;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _users;
    public UsersController(IUserService users) => _users = users;

    [Authorize]
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<UserDto>> GetUser(Guid id)
        => Ok(await _users.GetByIdAsync(id));

    [Authorize]
    [HttpPut("{id:guid}/profile")]
    public async Task<ActionResult<UserDto>> UpdateProfile(Guid id, UpdateProfileRequest request)
        => Ok(await _users.UpdateProfileAsync(id, request));

    [Authorize(Roles = "Admin")]
    [HttpGet("all")]
    public async Task<ActionResult<List<UserDto>>> GetAll()
        => Ok(await _users.GetAllAsync());

    [AllowAnonymous]
    [HttpGet("{id:guid}/exists")]
    public async Task<ActionResult<bool>> Exists(Guid id)
        => Ok(await _users.ExistsAsync(id));
}
