using System.Threading;
using System.Threading.Tasks;

namespace CarFactory.Common
{
    public interface IPartCommand
    {
        Task<IPartModel> ExecuteAsync(CancellationToken token);
    }
}
