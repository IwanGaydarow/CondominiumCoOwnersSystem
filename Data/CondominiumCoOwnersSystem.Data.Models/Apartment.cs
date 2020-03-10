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

        public int BuildingId { get; set; }

        public Building Building { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public virtual ICollection<ApartmentMontlyObligation> MontlyObligations { get; set; }
    }
}
