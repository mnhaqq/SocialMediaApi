using SocialMediaApi.Core.Entities;
using SocialMediaApi.Core.Interfaces.Common;

namespace SocialMediaApi.Core.Interfaces;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetByUsername(string username);
}
