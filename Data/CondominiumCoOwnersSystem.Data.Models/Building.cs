namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Common;
    using CondominiumCoOwnersSystem.Data.Common.Models;
    using CondominiumCoOwnersSystem.Data.Models.Enums;

    public class Building : BaseDeletableModel<int>
    {
        public Building()
        {
            this.Apartments = new HashSet<Apartment>();
            this.BuildingServiceSubscriptions = new HashSet<BuildingServiceSubscription>();
            this.BuildingUtilityBills = new HashSet<BuildingUtilityBills>();
            this.BuildingAdditionalRepairs = new HashSet<BuildingAdditionalRepairs>();
        }

        [StringLength(GlobalConstants.BuildingNameLenght)]
        public string Name { get; set; }

        [Required]
        [StringLength(GlobalConstants.BuildingStreetLenght)]
        public string Street { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public int FundRepairId { get; set; }

        public FundRepair FundRepair { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; }

        public virtual ICollection<BuildingServiceSubscription> BuildingServiceSubscriptions { get; set; }

        public virtual ICollection<BuildingUtilityBills> BuildingUtilityBills { get; set; }

        public virtual ICollection<BuildingAdditionalRepairs> BuildingAdditionalRepairs { get; set; }
    }
}
