using System;
using CarFactory.Common.Extensions;
using CarFactory.Modules.Engine.Models;

namespace CarFactory.Modules.Engine.Views
{
    internal class EngineView : IEngineView
    {
        public EngineType GetEngineType()
        {
            var array = Enum.GetNames(typeof(EngineType));
            var text = array.ToMessageWithBrackets("\nSelect engine type");

            Console.WriteLine(text);

            var userInput = Console.ReadLine();

            if (Enum.TryParse<EngineType>(userInput.ToTitleCase(), out var result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("\nThe selected engine does not exist.");
                return GetEngineType();
            }
        }
    }
}
