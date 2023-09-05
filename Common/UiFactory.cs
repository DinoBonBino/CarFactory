using System.Threading;
using System.Threading.Tasks;
using Autofac;

namespace CarFactory.Common
{
    internal class UiFactory: IUiFactory
    {
        private readonly ILifetimeScope _scope;

        public UiFactory(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public Task<T> CreateAsync<T>(CancellationToken token) where T : IView
        {
            return Task.Factory.StartNew(() => _scope.Resolve<T>(), token); // оборачиваем в таску, т.к. создание вью может занимать время
        }
    }
}
