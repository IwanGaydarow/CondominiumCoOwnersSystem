﻿namespace CondominiumCoOwnersSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Data.Common.Models;

    public class CompanyType : BaseDeletableModel<int>
    {
        [Required]
        [StringLength(150)]
        public string TypeOfServices { get; set; }
    }
}
