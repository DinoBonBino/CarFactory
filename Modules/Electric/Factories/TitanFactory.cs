using CarFactory.Common;
using CarFactory.Modules.Electric.Models;

namespace CarFactory.Modules.Electric.Factories
{
    internal class TitanFactory : IElectricFactory
    {
        public ElectricType ElectricType => ElectricType.Titan;

        public IPartModel Create()
        {
            return new TitanModel();
        }
    }
}
