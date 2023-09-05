using CarFactory.Common;
using CarFactory.Modules.Engine.Models;

namespace CarFactory.Modules.Engine.Factories
{
    internal interface IEngineFactory
    {
        EngineType EngineType { get;}

        IPartModel Create();
    }
}