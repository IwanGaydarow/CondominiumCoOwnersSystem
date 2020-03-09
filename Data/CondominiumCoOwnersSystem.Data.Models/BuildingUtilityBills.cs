namespace CondominiumCoOwnersSystem.Data.Models
{
    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class BuildingUtilityBills : BaseDeletableModel<int>
    {
        public decimal Cost { get; set; }

        public int UtilityId { get; set; }

        public Utility Utility { get; set; }

        public int BuildingId { get; set; }

        public Building Building { get; set; }
    }
}
