using Microsoft.AspNetCore.Identity;
using MiniFacebook.Models.Entities;
using MiniFacebook.Shared.GlobalRepository;

namespace MiniFacebook.DAL.Repository.UserRepository
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
