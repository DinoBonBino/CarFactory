using CarFactory.Common;

namespace CarFactory.Modules.Electric.Models
{
    internal class GoldModel : IPartModel
    {
        public string Name => ElectricType.Gold.ToString();

        public int Cost => 250;
    }
}
