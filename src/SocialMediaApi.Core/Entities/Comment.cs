using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Comment : BaseEntity
{
    public required User User { get; set; }
    public required Post Post { get; set; }
    public required string Content { get; set;}
}
