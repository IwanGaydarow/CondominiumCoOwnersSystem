﻿namespace CondominiumCoOwnersSystem.Web.ViewModels.Reports
{
    using System;

    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class BuildingUtilityBillsViewModel : IMapFrom<BuildingUtilityBills>
    {
        public string UtilityName { get; set; }

        public DateTime CreatedOn { get; set; }

        public decimal Cost { get; set; }
    }
}
