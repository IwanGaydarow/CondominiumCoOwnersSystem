namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class Service : BaseDeletableModel<int>
    {
        [StringLength(300)]
        public string Description { get; set; }
    }
}
