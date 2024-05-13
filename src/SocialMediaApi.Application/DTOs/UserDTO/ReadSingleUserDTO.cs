using System.ComponentModel.DataAnnotations;

namespace SocialMediaApi.Application.Dtos.UserDto;

public class ReadSingleUserDTO
{
    public string? Bio { get; set; }

    [Url]
    public string? ProfilePic { get; set; }
    public string Name { get; set; } = null!;

    [EmailAddress]
    public string Email { get; set; } = null!;

    public string Username { get; set; } = null!;

}
