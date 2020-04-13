namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Data.Common.Models;
    using CondominiumCoOwnersSystem.Data.Models.Enums;

    public class FundRepair : BaseDeletableModel<int>
    {
        public decimal Fee { get; set; }

        [Required]
        public PaymentMethod TypeOfDestribution { get; set; }

        public int BuildingId { get; set; }

        public Building Building { get; set; }
    }
}
