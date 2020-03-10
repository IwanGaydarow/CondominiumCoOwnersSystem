namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class FundRepairSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.FundRepairs.Any())
            {
                return;
            }

            var fundRepairs =
                new List<FundRepair>()
                {
                    new FundRepair { Fee = 80M, BuildingId = 1, TypeOfDestribution = "Apartment" },
                    new FundRepair { Fee = 60M, BuildingId = 2, TypeOfDestribution = "Apartment" },
                    new FundRepair { Fee = 75M, BuildingId = 3, TypeOfDestribution = "IdealParts" },
                };

            foreach (var fundRepair in fundRepairs)
            {
                await dbContext.FundRepairs.AddAsync(fundRepair);
            }
        }
    }
}
