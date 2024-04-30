using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Like:BaseEntity
{
    public required User User { get; set; }
    public required Post Post { get; set; }


}
