using CarFactory.Common;
using CarFactory.Modules.Engine.Models;

namespace CarFactory.Modules.Engine.Factories
{
    internal class ElectroFactory : IEngineFactory
    {
        public EngineType EngineType => EngineType.Electro;

        public IPartModel Create()
        {
            return new ElectroModel();
        }
    }
}
