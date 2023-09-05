using CarFactory.Common;
using CarFactory.Modules.Body.Models;

namespace CarFactory.Modules.Body.Factories
{
    internal class SedanFactory : IBodyFactory
    {
        public BodyType BodyType => BodyType.Sedan;

        public IPartModel Create()
        {
            return new SedanModel();
        }
    }
}
