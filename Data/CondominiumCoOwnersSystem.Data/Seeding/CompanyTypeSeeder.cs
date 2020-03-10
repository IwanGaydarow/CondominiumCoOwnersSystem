﻿namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class CompanyTypeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.CompanyTypes.Any())
            {
                return;
            }

            var companyTypes =
                new List<CompanyType>()
                {
                    new CompanyType { TypeOfServices = "Elevator maintenance" },
                    new CompanyType { TypeOfServices = "Cleaning company" },
                };

            foreach (var companyType in companyTypes)
            {
                await dbContext.CompanyTypes.AddAsync(companyType);
            }
        }
    }
}
