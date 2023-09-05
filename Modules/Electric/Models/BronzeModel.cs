using CarFactory.Common;

namespace CarFactory.Modules.Electric.Models
{
    internal class BronzeModel : IPartModel
    {
        public string Name => ElectricType.Bronze.ToString();

        public int Cost => 120;
    }
}
