using CarFactory.Common;
using CarFactory.Modules.Body.Models;

namespace CarFactory.Modules.Body.Factories
{
    internal class MinivanFactory : IBodyFactory
    {
        public BodyType BodyType => BodyType.Minivan;

        public IPartModel Create()
        {
            return new MinivanModel();
        }
    }
}
