using CarFactory.Common;
using CarFactory.Modules.Electric.Models;

namespace CarFactory.Modules.Electric.Factories
{
    internal class BronzeFactory : IElectricFactory
    {
        public ElectricType ElectricType => ElectricType.Bronze;

        public IPartModel Create()
        {
            return new BronzeModel();
        }
    }
}
