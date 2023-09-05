using CarFactory.Common;
using CarFactory.Modules.Body.Models;

namespace CarFactory.Modules.Body.Factories
{
    internal class CupeFactory : IBodyFactory
    {
        public BodyType BodyType => BodyType.Cupe;

        public IPartModel Create()
        {
            return new CupeModel();
        }
    }
}
