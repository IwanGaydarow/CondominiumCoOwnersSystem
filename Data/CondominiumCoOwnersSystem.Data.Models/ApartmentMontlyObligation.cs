namespace CondominiumCoOwnersSystem.Data.Models
{
    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class ApartmentMontlyObligation : BaseDeletableModel<int>
    {
        public decimal MontlyObligation { get; set; }

        public int ApartmentId { get; set; }

        public Apartment Apartment { get; set; }
    }
}
