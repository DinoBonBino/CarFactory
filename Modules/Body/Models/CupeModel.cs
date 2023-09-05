using CarFactory.Common;

namespace CarFactory.Modules.Body.Models
{
    internal class CupeModel : IPartModel
    {
        public string Name => BodyType.Cupe.ToString();

        public int Cost => 1100;
    }
}
