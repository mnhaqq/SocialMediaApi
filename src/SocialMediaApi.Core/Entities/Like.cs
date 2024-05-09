using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Like:BaseEntity
{
    public int? Userid { get; set; }
    public int? Postid { get; set; }
    public virtual Post? Post { get; set; }
    public virtual User? User { get; set; }
}
