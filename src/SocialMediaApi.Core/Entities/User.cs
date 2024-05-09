using SocialMediaApi.Core.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace SocialMediaApi.Core.Entities;

public class User:BaseEntity
{
    public string? Bio { get; set; }
    [Url]
    public string? Profilepic { get; set; }
    public string Name { get; set; } = null!;
    [EmailAddress]
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Username { get; set; } = null!;
    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public virtual ICollection<Following> FollowingFollowingusers { get; set; } = new List<Following>();
    public virtual ICollection<Following> FollowingUsers { get; set; } = new List<Following>();
    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();
    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}