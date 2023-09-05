using Autofac;
using CarFactory.Common;
using CarFactory.Common.Extensions;
using CarFactory.Modules.Body.Commands;
using CarFactory.Modules.Body.Factories;
using CarFactory.Modules.Body.Views;

namespace CarFactory.Modules.Body
{
    public class BodyModule
    {
        public BodyModule(ContainerBuilder builder)
        {
            builder.Register<IPartCommand, BodyCommand>();
            builder.Register<IBodyView, BodyView>();
            builder.Register<IBodyFactory, SedanFactory>();
            builder.Register<IBodyFactory, CupeFactory>();
            builder.Register<IBodyFactory, SuvFactory>();
            builder.Register<IBodyFactory, MinivanFactory>();
            builder.Register<IBodyFactory, SportsFactory>();
        }
    }
}
