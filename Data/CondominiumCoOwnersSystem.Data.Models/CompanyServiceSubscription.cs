namespace CondominiumCoOwnersSystem.Data.Models
{
    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class CompanyServiceSubscription : BaseDeletableModel<int>
    {
        public int CompnayId { get; set; }

        public Company Company { get; set; }

        public int BuildingId { get; set; }

        public Building Building { get; set; }

        public int ServiceId { get; set; }

        public Service Service { get; set; }

        public int MontlyServiceFeeId { get; set; }

        public MontlyServiceFee ServiceFee { get; set; }

        public decimal TotalFee { get; set; }
    }
}
