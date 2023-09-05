using System.Threading;
using System.Threading.Tasks;

namespace CarFactory.Common
{
    public interface IUiFactory 
    {
        Task<T> CreateAsync<T>(CancellationToken token) where T : IView;
    }
}
