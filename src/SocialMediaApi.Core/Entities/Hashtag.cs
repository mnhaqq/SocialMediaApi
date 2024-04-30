using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Hashtag : BaseEntity
{   public required string hashtag {  get; set; }
    public Post post { get; set; }
}
