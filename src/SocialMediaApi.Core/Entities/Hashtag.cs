using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Hashtag : BaseEntity
{   public required string Content { get; set; }
    public Post? Post { get; set; }
}
