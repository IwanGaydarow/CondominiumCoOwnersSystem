namespace CondominiumCoOwnersSystem.Data.Models
{
    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class CompanyMontlyServiceFee : BaseDeletableModel<int>
    {
        public int BuildingServiceSubscriptionId { get; set; }

        public BuildingServiceSubscription BuildingServiceSubscription { get; set; }

        public decimal Fee { get; set; }
    }
}
