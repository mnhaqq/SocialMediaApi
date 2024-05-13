using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Following:BaseEntity
{
    public int? UserId { get; set; }

    public int? FollowingUserId { get; set; }

    public virtual User? FollowingUser { get; set; }

    public virtual User? User { get; set; }

}
