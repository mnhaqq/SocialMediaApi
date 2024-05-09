using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Hashtag : BaseEntity
{  
    public string Content { get; set; } = null!;
    public int? Postid { get; set; }
    public virtual Post? Post { get; set; }
}
