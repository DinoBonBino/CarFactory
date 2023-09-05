using CarFactory.Common;

namespace CarFactory.Modules.Body.Models
{
    internal class SedanModel : IPartModel
    {
        public string Name => BodyType.Sedan.ToString();

        public int Cost => 1000;
    }
}
