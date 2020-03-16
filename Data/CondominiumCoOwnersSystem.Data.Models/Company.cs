namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Common;
    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class Company : BaseDeletableModel<int>
    {
        public Company()
        {
            this.BuildingServiceSubscription = new HashSet<BuildingServiceSubscription>();
        }

        [Required]
        [StringLength(GlobalConstants.CompanyNameLenght)]
        public string Name { get; set; }

        public int CompanyTypeId { get; set; }

        public CompanyType CompanyType { get; set; }

        [StringLength(GlobalConstants.CompanyPhoneNumberLenght)]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public virtual ICollection<BuildingServiceSubscription> BuildingServiceSubscription { get; set; }
    }
}
