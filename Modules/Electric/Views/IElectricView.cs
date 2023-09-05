using CarFactory.Common;
using CarFactory.Modules.Electric.Models;

namespace CarFactory.Modules.Electric.Views
{
    public interface IElectricView : IView
    {
        ElectricType GetElectricType();
    }
}