using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CarFactory.Common;
using CarFactory.Modules.Electric.Factories;
using CarFactory.Modules.Electric.Views;

namespace CarFactory.Modules.Electric.Commands
{
    internal class ElectricCommand : IPartCommand
    {
        private readonly IUiFactory _uiFactory;
        private readonly IList<IElectricFactory> _electricFactories;

        public ElectricCommand(
            IUiFactory uiFactory,
            IList<IElectricFactory> electricFactories)
        {
            _uiFactory = uiFactory;
            _electricFactories = electricFactories;
        }

        public async Task<IPartModel> ExecuteAsync(CancellationToken token)
        {
            var view = await _uiFactory.CreateAsync<IElectricView>(token);

            if(token.IsCancellationRequested || view == null)
            {
                return null;
            }

            var electricType = view.GetElectricType();

            var factory = _electricFactories.FirstOrDefault(x => x.ElectricType == electricType);
            if(factory != null)
            {
                return factory.Create();
            }

            return null;
        }
    }
}
