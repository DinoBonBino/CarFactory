using CarFactory.Common;
using CarFactory.Modules.Engine.Models;

namespace CarFactory.Modules.Engine.Factories
{
    internal class GasFactory : IEngineFactory
    {
        public EngineType EngineType => EngineType.Gas;

        public IPartModel Create()
        {
            return new GasModel();
        }
    }
}
