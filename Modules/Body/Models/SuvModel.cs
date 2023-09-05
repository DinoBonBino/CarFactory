using CarFactory.Common;

namespace CarFactory.Modules.Body.Models
{
    internal class SuvModel : IPartModel
    {
        public string Name => BodyType.Suv.ToString();

        public int Cost => 1200;
    }
}
