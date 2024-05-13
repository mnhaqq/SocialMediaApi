using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Like:BaseEntity
{
    public int? UserId { get; set; }
    public int? PostId { get; set; }
    public virtual Post? Post { get; set; }
    public virtual User? User { get; set; }
}
