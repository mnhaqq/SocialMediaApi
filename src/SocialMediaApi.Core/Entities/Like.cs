using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Like:BaseEntity
{
    public required User user { get; set; }
    public required Post post { get; set; }


}
