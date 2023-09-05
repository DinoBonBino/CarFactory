using CarFactory.Common;

namespace CarFactory.Modules.Engine.Models
{
    internal class GasModel : IPartModel
    {
        public string Name => EngineType.Gas.ToString();

        public int Cost => 600;
    }
}
