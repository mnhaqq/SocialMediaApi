using SocialMediaApi.Core.Entities;
using SocialMediaApi.Core.Interfaces.Common;

namespace SocialMediaApi.Core.Interfaces;

public interface ILikeRepository : IBaseRepository<Like>
{
    Task<IEnumerable<Like>> GetLikesByPost(int postId);
}
