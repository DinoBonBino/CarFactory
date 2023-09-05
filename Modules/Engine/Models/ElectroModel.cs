using CarFactory.Common;

namespace CarFactory.Modules.Engine.Models
{
    internal class ElectroModel : IPartModel
    {
        public string Name => EngineType.Electro.ToString();

        public int Cost => 700;
    }
}
