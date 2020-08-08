using Microsoft.EntityFrameworkCore;
using MiniFacebook.DAL.DataContext;
using MiniFacebook.Models.Entities;
using MiniFacebook.Shared.GlobalRepository;

namespace MiniFacebook.DAL.Repository.PostRepository
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
