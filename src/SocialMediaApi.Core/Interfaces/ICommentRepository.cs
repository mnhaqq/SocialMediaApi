using SocialMediaApi.Core.Entities;
using SocialMediaApi.Core.Interfaces.Common;

namespace SocialMediaApi.Core.Interfaces;

public interface ICommentRepository : IBaseRepository<Comment>
{
    Task<IEnumerable<Comment>> GetCommentsByPost(int postId);
}
