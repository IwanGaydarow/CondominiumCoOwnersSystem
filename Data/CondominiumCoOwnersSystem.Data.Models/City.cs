namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Common;
    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class City : BaseDeletableModel<int>
    {
        public City()
        {
            this.Buildings = new HashSet<Building>();
        }

        [Required]
        [StringLength(GlobalConstants.CityNameLenght)]
        public string Name { get; set; }

        public virtual ICollection<Building> Buildings { get; set; }
    }
}
