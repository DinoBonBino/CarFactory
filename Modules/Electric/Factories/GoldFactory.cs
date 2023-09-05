using CarFactory.Common;
using CarFactory.Modules.Electric.Models;

namespace CarFactory.Modules.Electric.Factories
{
    internal class GoldFactory : IElectricFactory
    {
        public ElectricType ElectricType => ElectricType.Gold;

        public IPartModel Create()
        {
            return new GoldModel();
        }
    }
}
