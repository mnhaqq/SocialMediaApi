using SocialMediaApi.Core.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace SocialMediaApi.Core.Entities;

public class User:BaseEntity
{
    public string? Bio {  get; set; }

    [Url]
    public string? ProfilePic {  get; set; }
    public required string Name { get; set; }

    [EmailAddress]
    public required string Email {  get; set; }
    public required string Password { get; set; } // Password Hashing would be done later
    public required string Username { get; set; }
    

}
