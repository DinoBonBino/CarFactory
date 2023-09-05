using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CarFactory.Common;
using CarFactory.Modules.Body.Factories;
using CarFactory.Modules.Body.Views;

namespace CarFactory.Modules.Body.Commands
{
    internal class BodyCommand : IPartCommand
    {
        private readonly IUiFactory _uiFactory;
        private readonly IList<IBodyFactory> _bodyFactories;

        public BodyCommand(
            IUiFactory uiFactory,
            IList<IBodyFactory> bodyFactories)
        {
            _uiFactory = uiFactory;
            _bodyFactories = bodyFactories;
        }

        public async Task<IPartModel> ExecuteAsync(CancellationToken token)
        {
            var view = await _uiFactory.CreateAsync<IBodyView>(token);

            if(token.IsCancellationRequested || view == null)
            {
                return null;
            }

            var bodyType = view.GetBodyType();

            var factory = _bodyFactories.FirstOrDefault(x => x.BodyType == bodyType);
            if(factory != null)
            {
                return factory.Create();
            }

            return null;
        }
    }
}
