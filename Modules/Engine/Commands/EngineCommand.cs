using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CarFactory.Common;
using CarFactory.Modules.Engine.Factories;
using CarFactory.Modules.Engine.Views;

namespace CarFactory.Modules.Engine.Commands
{
    internal class EngineCommand : IPartCommand
    {
        private readonly IUiFactory _uiFactory;
        private readonly IList<IEngineFactory> _engineFactories;

        public EngineCommand(
            IUiFactory uiFactory,
            IList<IEngineFactory> engineFactories)
        {
            _uiFactory = uiFactory;
            _engineFactories = engineFactories;
        }

        public async Task<IPartModel> ExecuteAsync(CancellationToken token)
        {
            var view = await _uiFactory.CreateAsync<IEngineView>(token);

            if(token.IsCancellationRequested || view == null)
            {
                return null;
            }

            var engineType = view.GetEngineType();

            var factory = _engineFactories.FirstOrDefault(x => x.EngineType == engineType);
            if(factory != null)
            {
                return factory.Create();
            }

            return null;
        }
    }
}
