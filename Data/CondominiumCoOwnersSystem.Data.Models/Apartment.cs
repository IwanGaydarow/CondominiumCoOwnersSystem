namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Common;
    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class Apartment : BaseDeletableModel<int>
    {
        public Apartment()
        {
            this.MontlyObligations = new HashSet<ApartmentMontlyObligation>();
        }

        public int Number { get; set; }

        [Range(GlobalConstants.MinApartmentFloor, GlobalConstants.MaxApartmentFloor)]
        public int Floor { get; set; }

        [Range(0, 15)]
        public int Inhabitants { get; set; }

        public decimal IdealParts { get; set; }

        [Required]
        public int BuildingId { get; set; }

        public Building Building { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public virtual ICollection<ApartmentMontlyObligation> MontlyObligations { get; set; }
    }
}
