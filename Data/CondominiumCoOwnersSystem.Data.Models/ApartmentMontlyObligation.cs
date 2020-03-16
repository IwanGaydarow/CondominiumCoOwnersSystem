namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class ApartmentMontlyObligation : BaseDeletableModel<int>
    {
        public decimal MontlyObligation { get; set; }

        [Range(0, 10)]
        public int Inhabitants { get; set; }

        public int ApartmentId { get; set; }

        public Apartment Apartment { get; set; }
    }
}
