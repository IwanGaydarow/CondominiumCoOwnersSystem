namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class Company : BaseDeletableModel<int>
    {
        [StringLength(100)]
        public string Name { get; set; }

        public int TypeOfCompanyId { get; set; }

        public CompanyType CompanyType { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }
    }
}
