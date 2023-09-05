using CarFactory.Common;
using CarFactory.Modules.Engine.Models;

namespace CarFactory.Modules.Engine.Factories
{
    internal class DieselFactory : IEngineFactory
    {
        public EngineType EngineType => EngineType.Diesel;

        public IPartModel Create()
        {
            return new DieselModel();
        }
    }
}
