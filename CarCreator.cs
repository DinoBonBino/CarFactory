using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CarFactory.Common;

namespace CarFactory
{
    //класс проходится по всем зарегестрированным модулям и собирает машину из предложенных деталей.
    //в текущей реализации имеется три модуля деталей (body, electric, engine).
    //для добавления нового типа детали достаточно создать новый модуль в намспейсе CarFactory.Module и добавить его модуль в CarFactoryModules.
    internal class CarCreator : ICarCreator
    {
        private readonly IList<IPartCommand> _partCommands;

        public CarCreator(IList<IPartCommand> partCommands)
        {
            _partCommands = partCommands;
        }

        public async Task RunAsync(CancellationToken token)
        {
            var partBuilder = new StringBuilder();
            var cost = 0;

            foreach (var partCommand in _partCommands)
            {
                var partModel = await partCommand.ExecuteAsync(token);

                if (token.IsCancellationRequested || partModel == null)
                {
                    AbortCreation();
                    return;
                }

                partBuilder.Append($"{partModel.Name}/");
                cost += partModel.Cost;
            }

            partBuilder.Remove(partBuilder.Length - 1, 1);

            Console.WriteLine($"\nA new car with selected parts [{partBuilder}] has been created.");
            Console.WriteLine($"cost is {cost}");
            Console.ReadKey();
        }

        private void AbortCreation()
        {
            Console.WriteLine("A new car creation has been aborted.");
        }
    }
}