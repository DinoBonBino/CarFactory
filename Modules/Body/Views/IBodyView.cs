using CarFactory.Common;
using CarFactory.Modules.Body.Models;

namespace CarFactory.Modules.Body.Views
{
    public interface IBodyView : IView
    {
        BodyType GetBodyType();
    }
}