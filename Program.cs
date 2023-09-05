using System.Threading;
using System.Threading.Tasks;
using Autofac;
using CarFactory.Modules;

namespace CarFactory
{
    //программа описывает завод по созданию машины.
    //для упрощения вью работают с консолью. при желании их без проблем можно заменить на UI.
    //
    class MainClass
    {
        public static async Task Main(string[] _)
        {
            var cancelTokenSource = new CancellationTokenSource();
            var token = cancelTokenSource.Token;
            var builder = new ContainerBuilder();

            RegisterModules(builder);

            using (var container = builder.Build())
            {
                await RunCreatorAsync(container, token);
            }
        }

        //регистрируем рутовый модуль и все остальные модуля из намспейса CarFactory.Modules
        private static void RegisterModules(ContainerBuilder builder)
        {
            new RootModule(builder);
            new CarFactoryModules(builder);
        }

        //запускаем класс выполняющий основную логику создания машины
        private static Task RunCreatorAsync(IContainer container, CancellationToken token)
        {
            var creator = container.Resolve<ICarCreator>();
            return creator.RunAsync(token);
        }
    }
}
