namespace CondominiumCoOwnersSystem.Data.Models
{
    using System;

    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class MontlyServiceFee : BaseDeletableModel<int>
    {
        public int? Subscription { get; set; }

        public DateTime Date { get; set; }

        public decimal Fee { get; set; }
    }
}
