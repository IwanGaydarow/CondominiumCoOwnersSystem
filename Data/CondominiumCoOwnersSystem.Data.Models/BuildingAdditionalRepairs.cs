namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class BuildingAdditionalRepairs : BaseDeletableModel<int>
    {
        [Required]
        public string MadeBy { get; set; }

        [Required]
        public string Description { get; set; }

        public decimal Cost { get; set; }

        public int BuildingId { get; set; }

        public Building Building { get; set; }
    }
}
