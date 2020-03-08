namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Data.Common.Models;
    using CondominiumCoOwnersSystem.Data.Models.Enums;

    public class Building : BaseDeletableModel<int>
    {
        public Building()
        {
            this.Apartments = new HashSet<Apartment>();
            this.CompanyServiceSubscriptions = new HashSet<CompanyServiceSubscription>();
        }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(150)]
        public string FullAddress { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public decimal TotalFundRepair { get; set; }

        public int FundRepairId { get; set; }

        public FundRepair FundRepair { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; }

        public virtual ICollection<CompanyServiceSubscription> CompanyServiceSubscriptions { get; set; }
    }
}
