using CarFactory.Common;
using CarFactory.Modules.Engine.Models;

namespace CarFactory.Modules.Engine.Views
{
    public interface IEngineView : IView
    {
        EngineType GetEngineType();
    }
}