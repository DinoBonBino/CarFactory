using CarFactory.Common;
using CarFactory.Modules.Body.Models;

namespace CarFactory.Modules.Body.Factories
{
    internal interface IBodyFactory
    {
        BodyType BodyType { get;}

        IPartModel Create();
    }
}