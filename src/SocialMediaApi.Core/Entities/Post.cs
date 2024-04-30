using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Post : BaseEntity
{
    public required User User { get; set; }
    public required string Content {get; set;}
    public string Hashtag { get; set;} = "";
}
