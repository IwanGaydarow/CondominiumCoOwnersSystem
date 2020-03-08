namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class CompanyType : BaseDeletableModel<int>
    {
        [StringLength(150)]
        public string Type { get; set; }
    }
}
