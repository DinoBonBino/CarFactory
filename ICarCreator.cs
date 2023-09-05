using System.Threading;
using System.Threading.Tasks;

namespace CarFactory
{
    internal interface ICarCreator
    {
        Task RunAsync(CancellationToken token);
    }
}