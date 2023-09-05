using CarFactory.Common;

namespace CarFactory.Modules.Engine.Models
{
    internal class DieselModel : IPartModel
    {
        public string Name => EngineType.Diesel.ToString();

        public int Cost => 700;
    }
}
