using CarFactory.Common;
using CarFactory.Modules.Body.Models;

namespace CarFactory.Modules.Body.Factories
{
    internal class SuvFactory : IBodyFactory
    {
        public BodyType BodyType => BodyType.Suv;

        public IPartModel Create()
        {
            return new SuvModel();
        }
    }
}
