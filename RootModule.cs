using Autofac;
using CarFactory.Common;
using CarFactory.Common.Extensions;

namespace CarFactory
{
    internal class RootModule
    {
        public RootModule(ContainerBuilder builder)
        {
            builder.Register<ICarCreator, CarCreator>();
            builder.Register<IUiFactory, UiFactory>();
        }
    }
}