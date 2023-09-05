using System;
using CarFactory.Common.Extensions;
using CarFactory.Modules.Electric.Models;

namespace CarFactory.Modules.Electric.Views
{
    internal class ElectricView : IElectricView
    {
        public ElectricType GetElectricType()
        {
            var array = Enum.GetNames(typeof(ElectricType));
            var text = array.ToMessageWithBrackets("\nSelect electric type");

            Console.WriteLine(text);

            var userInput = Console.ReadLine();

            if (Enum.TryParse<ElectricType>(userInput.ToTitleCase(), out var result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("\nThe selected electric does not exist.");
                return GetElectricType();
            }
        }
    }
}
