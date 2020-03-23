namespace CondominiumCoOwnersSystem.Web.ViewModels.Apartmеnts
{
    using System.Collections.Generic;

    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class BuildingDropDownViewModel : IMapFrom<Building>
    {
        public int Id { get; set; }

        public string Street { get; set; }
    }
}