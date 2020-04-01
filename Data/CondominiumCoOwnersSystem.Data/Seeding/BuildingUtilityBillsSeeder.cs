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
                    new BuildingUtilityBills { BuildingId = 1, Cost = 18.50M, UtilityId = 1, CreatedOn = new DateTime(2020, 1, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 1, Cost = 17.30M, UtilityId = 1, CreatedOn = new DateTime(2020, 2, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 1, Cost = 16.43M, UtilityId = 1, CreatedOn = new DateTime(2020, 3, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 2, Cost = 18M, UtilityId = 1, CreatedOn = new DateTime(2020, 1, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 2, Cost = 17.83M, UtilityId = 1, CreatedOn = new DateTime(2020, 2, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 2, Cost = 16.89M, UtilityId = 1, CreatedOn = new DateTime(2020, 3, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 2, Cost = 8.45M, UtilityId = 5, CreatedOn = new DateTime(2020, 1, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 2, Cost = 7.30M, UtilityId = 5, CreatedOn = new DateTime(2020, 2, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 2, Cost = 5.40M, UtilityId = 5, CreatedOn = new DateTime(2020, 3, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 3, Cost = 5.65M, UtilityId = 1, CreatedOn = new DateTime(2020, 1, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 3, Cost = 6.28M, UtilityId = 1, CreatedOn = new DateTime(2020, 2, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 3, Cost = 4.89M, UtilityId = 1, CreatedOn = new DateTime(2020, 3, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 4, Cost = 7.60M, UtilityId = 3, CreatedOn = new DateTime(2020, 1, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 4, Cost = 8.45M, UtilityId = 3, CreatedOn = new DateTime(2020, 2, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 4, Cost = 6.90M, UtilityId = 3, CreatedOn = new DateTime(2020, 3, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 4, Cost = 6.48M, UtilityId = 4, CreatedOn = new DateTime(2020, 1, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 4, Cost = 5.45M, UtilityId = 4, CreatedOn = new DateTime(2020, 2, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 4, Cost = 8.80M, UtilityId = 4, CreatedOn = new DateTime(2020, 3, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 5, Cost = 4.87M, UtilityId = 3, CreatedOn = new DateTime(2020, 1, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 5, Cost = 3.90M, UtilityId = 3, CreatedOn = new DateTime(2020, 2, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 5, Cost = 5.25M, UtilityId = 3, CreatedOn = new DateTime(2020, 3, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 6, Cost = 3.80M, UtilityId = 3, CreatedOn = new DateTime(2020, 1, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 6, Cost = 4.40M, UtilityId = 3, CreatedOn = new DateTime(2020, 2, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 6, Cost = 5.05M, UtilityId = 3, CreatedOn = new DateTime(2020, 3, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 7, Cost = 9.48M, UtilityId = 2, CreatedOn = new DateTime(2020, 1, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 7, Cost = 10.40M, UtilityId = 2, CreatedOn = new DateTime(2020, 2, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 7, Cost = 12.50M, UtilityId = 2, CreatedOn = new DateTime(2020, 3, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 8, Cost = 8.30M, UtilityId = 2, CreatedOn = new DateTime(2020, 1, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 8, Cost = 7.89M, UtilityId = 2, CreatedOn = new DateTime(2020, 2, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 8, Cost = 9.49M, UtilityId = 2, CreatedOn = new DateTime(2020, 3, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 9, Cost = 7.40M, UtilityId = 2, CreatedOn = new DateTime(2020, 1, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 9, Cost = 6.66M, UtilityId = 2, CreatedOn = new DateTime(2020, 2, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 9, Cost = 8.12M, UtilityId = 2, CreatedOn = new DateTime(2020, 3, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 9, Cost = 8.60M, UtilityId = 6, CreatedOn = new DateTime(2020, 1, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 9, Cost = 4.80M, UtilityId = 6, CreatedOn = new DateTime(2020, 2, 15, 12, 34, 34) },
                    new BuildingUtilityBills { BuildingId = 9, Cost = 5.55M, UtilityId = 6, CreatedOn = new DateTime(2020, 3, 15, 12, 34, 34) },
                };

            foreach (var biil in buildingBills)
            {
                await dbContext.BuildingUtilityBills.AddAsync(biil);
            }
        }
    }
}
