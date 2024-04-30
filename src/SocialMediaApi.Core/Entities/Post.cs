using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Post : BaseEntity
{
    public required User user { get; set; }
    public required string Content {get; set;}
    public string hashtags { get; set;}
}
