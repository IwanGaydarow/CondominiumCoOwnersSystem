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
                    new FundRepair { Fee = 60M, BuildingId = 1, TypeOfDestribution = "На брой апартаменти" },
                    new FundRepair { Fee = 50M, BuildingId = 2, TypeOfDestribution = "Според идеалните части" },
                    new FundRepair { Fee = 40M, BuildingId = 3, TypeOfDestribution = "Според брой живущи" },
                    new FundRepair { Fee = 50M, BuildingId = 4, TypeOfDestribution = "На брой апартаменти" },
                    new FundRepair { Fee = 30M, BuildingId = 5, TypeOfDestribution = "На брой апартаменти" },
                    new FundRepair { Fee = 45M, BuildingId = 6, TypeOfDestribution = "Според брой живущи" },
                    new FundRepair { Fee = 35M, BuildingId = 7, TypeOfDestribution = "Според идеалните части" },
                    new FundRepair { Fee = 65M, BuildingId = 8, TypeOfDestribution = "На брой апартаменти" },
                    new FundRepair { Fee = 50M, BuildingId = 9, TypeOfDestribution = "Според брой живущи" },
                };

            foreach (var fundRepair in fundRepairs)
            {
                await dbContext.FundRepairs.AddAsync(fundRepair);
            }
        }
    }
}
