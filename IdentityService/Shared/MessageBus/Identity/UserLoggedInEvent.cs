namespace IdentityService.Shared.MessageBus.Identity
{
    /// <summary>
    /// Kullanıcı login olduğunda SocialService'e bildirmek için kullanılan event
    /// </summary>
    public record UserLoggedInEvent(
        Guid UserId,
        string UserName,
        string Email,
        string Role,
        string DeviceId,
        DateTime LoggedInAtUtc
    );
}

