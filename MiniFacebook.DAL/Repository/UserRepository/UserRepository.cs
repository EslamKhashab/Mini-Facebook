using Microsoft.EntityFrameworkCore;
using MiniFacebook.Models.Entities;
using MiniFacebook.Shared.GlobalRepository;

namespace MiniFacebook.DAL.Repository.UserRepository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
