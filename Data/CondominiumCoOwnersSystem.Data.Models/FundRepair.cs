namespace CondominiumCoOwnersSystem.Data.Models
{
    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class FundRepair : BaseDeletableModel<int>
    {
        public decimal Fee { get; set; }

        public string TypeOfDestribution { get; set; }

        public int BuildingId { get; set; }

        public Building Building { get; set; }
    }
}
