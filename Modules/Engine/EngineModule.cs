using Autofac;
using CarFactory.Common;
using CarFactory.Common.Extensions;
using CarFactory.Modules.Engine.Commands;
using CarFactory.Modules.Engine.Factories;
using CarFactory.Modules.Engine.Views;

namespace CarFactory.Modules.Engine
{
    public class EngineModule
    {
        public EngineModule(ContainerBuilder builder)
        {
            builder.Register<IPartCommand, EngineCommand>();
            builder.Register<IEngineView, EngineView>();
            builder.Register<IEngineFactory, GasFactory>();
            builder.Register<IEngineFactory, DieselFactory>();
            builder.Register<IEngineFactory, ElectroFactory>();
        }
    }
}
