using SocialMediaApi.Core.Entities;
using SocialMediaApi.Core.Interfaces.Common;

namespace SocialMediaApi.Core.Interfaces;

public interface IPostRepository : IBaseRepository<Post>
{
    Task<IEnumerable<Post>> GetPostsByUser(int userId);
}
