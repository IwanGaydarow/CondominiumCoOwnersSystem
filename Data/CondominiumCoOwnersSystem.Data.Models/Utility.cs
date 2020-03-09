namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class Utility : BaseModel<int>
    {
        [Required]
        public string Name { get; set; }
    }
}
