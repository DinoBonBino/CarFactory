using System;
using CarFactory.Common.Extensions;
using CarFactory.Modules.Body.Models;

namespace CarFactory.Modules.Body.Views
{
    internal class BodyView : IBodyView
    {
        public BodyType GetBodyType()
        {
            var array = Enum.GetNames(typeof(BodyType));
            var text = array.ToMessageWithBrackets("\nSelect body type");

            Console.WriteLine(text);

            var userInput = Console.ReadLine();

            if (Enum.TryParse<BodyType>(userInput.ToTitleCase(), out var result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("\nThe selected body does not exist.");
                return GetBodyType();
            }
        }
    }
}
