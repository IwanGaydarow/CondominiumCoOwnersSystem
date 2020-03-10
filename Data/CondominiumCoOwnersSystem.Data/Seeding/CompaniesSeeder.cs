namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class CompaniesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Companies.Any())
            {
                return;
            }

            var companies =
                new List<Company>()
                {
                    new Company { Address = "Varna, Topola 14", CompanyTypeId = 1, Name = "MM Lifts" },
                    new Company { Address = "Sofia, Kustendja 34", CompanyTypeId = 2, Name = "Clean Home" },
                    new Company { Address = "Plovdiv, Trakia, Topola 54", CompanyTypeId = 1, Name = "Plovdiv Lift" },
                };

            foreach (var company in companies)
            {
                await dbContext.Companies.AddAsync(company);
            }
        }
    }
}
