namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Common;
    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class CompanyType : BaseDeletableModel<int>
    {
        [Required]
        [StringLength(GlobalConstants.CompanyTypeServiceLenght)]
        public string TypeOfServices { get; set; }
    }
}
