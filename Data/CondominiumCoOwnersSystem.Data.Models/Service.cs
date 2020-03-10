namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Common;
    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class Service : BaseDeletableModel<int>
    {
        [Required]
        [StringLength(GlobalConstants.ServiceDescriptionLenght)]
        public string Description { get; set; }

        public int BuildingServiceSubscriptionId { get; set; }

        public BuildingServiceSubscription BuildingServiceSubscription { get; set; }
    }
}
