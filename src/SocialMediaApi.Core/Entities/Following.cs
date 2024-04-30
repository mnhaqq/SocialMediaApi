using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Following:BaseEntity
{
   public required User user { get; set; }
    public required User FollowingUser { get; set; }

}
