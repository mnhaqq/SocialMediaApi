﻿using SocialMediaApi.Core.Entities.Common;

namespace SocialMediaApi.Core.Entities;

public class Post : BaseEntity
{
    public int? UserId { get; set; }

    public string Content { get; set; } = null!;

    public string? HashTag { get; set; }
    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Hashtag> HashTags { get; set; } = new List<Hashtag>();

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual User? User { get; set; }
}
