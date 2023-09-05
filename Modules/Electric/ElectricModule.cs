using Autofac;
using CarFactory.Common;
using CarFactory.Common.Extensions;
using CarFactory.Modules.Electric.Commands;
using CarFactory.Modules.Electric.Factories;
using CarFactory.Modules.Electric.Views;

namespace CarFactory.Modules.Electric
{
    public class ElectricModule
    {
        public ElectricModule(ContainerBuilder builder)
        {
            builder.Register<IPartCommand, ElectricCommand>();
            builder.Register<IElectricView, ElectricView>();
            builder.Register<IElectricFactory, GoldFactory>();
            builder.Register<IElectricFactory, BronzeFactory>();
            builder.Register<IElectricFactory, TitanFactory>();
        }
    }
}
