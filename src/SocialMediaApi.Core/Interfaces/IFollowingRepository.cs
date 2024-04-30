using SocialMediaApi.Core.Entities;
using SocialMediaApi.Core.Interfaces.Common;

namespace SocialMediaApi.Core.Interfaces;

public interface IFollowingRepository : IBaseRepository<Following>
{
    Task<IEnumerable<Following>> GetFollowingByUser(int userId);
}
