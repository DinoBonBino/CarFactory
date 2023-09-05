using CarFactory.Common;

namespace CarFactory.Modules.Body.Models
{
    internal class MinivanModel : IPartModel
    {
        public string Name => BodyType.Minivan.ToString();

        public int Cost => 1300;
    }
}
