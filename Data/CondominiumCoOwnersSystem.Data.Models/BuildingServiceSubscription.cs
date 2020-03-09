namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.Collections.Generic;

    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class BuildingServiceSubscription : BaseDeletableModel<int>
    {
        public BuildingServiceSubscription()
        {
            this.Services = new HashSet<Service>();
            this.CompanyMontlyServiceFees = new HashSet<CompanyMontlyServiceFee>();
        }

        public int CompanyId { get; set; }

        public Company Company { get; set; }

        public int BuildingId { get; set; }

        public Building Building { get; set; }

        public decimal Fee { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<CompanyMontlyServiceFee> CompanyMontlyServiceFees { get; set; }
    }
}
