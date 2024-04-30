using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Comment : BaseEntity
{
    public required User user { get; set; }
    public required Post post { get; set; }
    public required string Content { get; set;}



}
