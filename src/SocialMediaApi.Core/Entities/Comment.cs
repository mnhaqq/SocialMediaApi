using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Comment : BaseEntity
{
    public int? UserId { get; set; }

    public int? PostId { get; set; }

    public string Content { get; set; } = null!;

    public virtual Post? Post { get; set; }

    public virtual User? User { get; set; }
}
