namespace CondominiumCoOwnersSystem.Data.Models
{
    using System;

    using CondominiumCoOwnersSystem.Data.Common.Models;
    using CondominiumCoOwnersSystem.Data.Models.Enums;

    public class BuildingUtilityBills : BaseDeletableModel<int>
    {
        public DateTime DateOfBill { get; set; }

        public decimal Cost { get; set; }

        public Utility UtilityType { get; set; }

        public int BuildingId { get; set; }

        public Building Building { get; set; }
    }
}
