using Autofac;
using CarFactory.Modules.Body;
using CarFactory.Modules.Electric;
using CarFactory.Modules.Engine;

namespace CarFactory.Modules
{
    //точка входа модулей. порядок имееет значение.
    //для отключения модуля достаточно закоментировать строчку создания модуля.
    public class CarFactoryModules
    {
        public CarFactoryModules(ContainerBuilder builder)
        {
            new BodyModule(builder);
            new EngineModule(builder);
            new ElectricModule(builder);
        }
    }
}
