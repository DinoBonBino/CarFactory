using CarFactory.Common;
using CarFactory.Modules.Body.Models;

namespace CarFactory.Modules.Body.Factories
{
    internal class SportsFactory : IBodyFactory
    {
        public BodyType BodyType => BodyType.Sport;

        public IPartModel Create()
        {
            return new SportsModel();
        }
    }
}
