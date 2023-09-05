using Autofac;

namespace CarFactory.Common.Extensions
{
    public static class AutofacExtensions
    {
        public static void Register<InterfaceT, ClassT>(this ContainerBuilder builder)
        {
            builder.RegisterType<ClassT>().As<InterfaceT>();
        }
    }
}
