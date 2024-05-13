using System.ComponentModel.DataAnnotations;

namespace SocialMediaApi.Application.Dtos.UserDto;

public class ReadAllUsersDTO
{
    public string Name { get; set; } = null!;
    [EmailAddress]
    public string Email { get; set; } = null!;

    public string Username { get; set; } = null!;
}
