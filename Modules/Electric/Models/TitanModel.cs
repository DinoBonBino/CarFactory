using CarFactory.Common;

namespace CarFactory.Modules.Electric.Models
{
    internal class TitanModel : IPartModel
    {
        public string Name => ElectricType.Titan.ToString();

        public int Cost => 400;
    }
}
