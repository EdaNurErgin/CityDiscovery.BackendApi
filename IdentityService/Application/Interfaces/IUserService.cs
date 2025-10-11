using IdentityService.Application.DTOs.Users;
using Shared.Common.DTOs.Identity;

namespace IdentityService.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> GetByIdAsync(Guid id);
        Task<UserDto> UpdateProfileAsync(Guid id, UpdateProfileRequest request);
        Task<List<UserDto>> GetAllAsync();             // Admin listeleme
        Task<bool> ExistsAsync(Guid id);               // Exists endpoint’i için
    }
}
