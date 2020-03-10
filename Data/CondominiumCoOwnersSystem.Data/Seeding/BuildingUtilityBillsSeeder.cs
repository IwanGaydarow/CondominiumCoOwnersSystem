namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class BuildingUtilityBillsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.BuildingUtilityBills.Any())
            {
                return;
            }

            var buildingBills =
                new List<BuildingUtilityBills>()
                {
                    new BuildingUtilityBills { BuildingId = 1, Cost = 90.45M, UtilityId = 1 },
                    new BuildingUtilityBills { BuildingId = 2, Cost = 87.98M, UtilityId = 3 },
                    new BuildingUtilityBills { BuildingId = 3, Cost = 102.78M, UtilityId = 2 },
                    new BuildingUtilityBills { BuildingId = 1, Cost = 35.45M, UtilityId = 5 },
                    new BuildingUtilityBills { BuildingId = 2, Cost = 45.52M, UtilityId = 4 },
                    new BuildingUtilityBills { BuildingId = 3, Cost = 28.75M, UtilityId = 6 },
                };

            foreach (var biil in buildingBills)
            {
                await dbContext.BuildingUtilityBills.AddAsync(biil);
            }
        }
    }
}
