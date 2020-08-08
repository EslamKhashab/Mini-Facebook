using Microsoft.EntityFrameworkCore;
using MiniFacebook.DAL.DataContext;
using MiniFacebook.Models.Entities;
using MiniFacebook.Shared.GlobalRepository;

namespace MiniFacebook.DAL.Repository.UserFriendRepository
{
    public class UserFriendRepository :Repository<UserFriend>, IUserFriendRepository
    {
        public UserFriendRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
