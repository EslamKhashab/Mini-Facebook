using System;
using System.Threading.Tasks;

namespace MiniFacebook.Shared.GlobalUOW
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
        Task<int> CompleteAsync();
    }
}
