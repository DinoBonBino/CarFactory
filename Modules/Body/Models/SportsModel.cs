using CarFactory.Common;

namespace CarFactory.Modules.Body.Models
{
    internal class SportsModel : IPartModel
    {
        public string Name => BodyType.Sport.ToString();

        public int Cost => 1400;
    }
}
