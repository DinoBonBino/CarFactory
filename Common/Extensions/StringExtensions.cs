using System.Globalization;
using System.Text;

namespace CarFactory.Common.Extensions
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this string s) => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(s.ToLowerInvariant());

        public static string ToMessageWithBrackets(this string[] array, string message)
        {
            var builder = new StringBuilder();
            builder.Append($"{message} [");

            for (int i = 0; i < array.Length; i++)
            {
                builder.Append($"{array[i]}");

                if (i == (array.Length - 1))
                {
                    builder.Append("]:");
                }
                else
                {
                    builder.Append(", ");
                }
            }

            return builder.ToString();
        }
    }
}
