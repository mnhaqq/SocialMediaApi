using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Following:BaseEntity
{
    public int? Userid { get; set; }

    public int? Followinguserid { get; set; }

    public virtual User? Followinguser { get; set; }

    public virtual User? User { get; set; }

}
