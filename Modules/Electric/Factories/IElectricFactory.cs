using CarFactory.Common;
using CarFactory.Modules.Electric.Models;

namespace CarFactory.Modules.Electric.Factories
{
    internal interface IElectricFactory
    {
        ElectricType ElectricType { get;}

        IPartModel Create();
    }
}