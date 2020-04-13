namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class BuildingServiceSubscriptionSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.BuildingServiceSubscriptions.Any())
            {
                return;
            }

            var buildingSubscriptions =
                new List<BuildingServiceSubscription>()
                {
                    new BuildingServiceSubscription { BuildingId = 1, CompanyId = 1, Fee = 65M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 1, CompanyId = 1, Fee = 65M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 1, CompanyId = 1, Fee = 65M, CreatedOn = new DateTime(2020, 3, 13) },
                    new BuildingServiceSubscription { BuildingId = 1, CompanyId = 6, Fee = 45M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 1, CompanyId = 6, Fee = 45M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 1, CompanyId = 6, Fee = 45M, CreatedOn = new DateTime(2020, 3, 13) },

                    new BuildingServiceSubscription { BuildingId = 2, CompanyId = 1, Fee = 65M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 2, CompanyId = 1, Fee = 65M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 2, CompanyId = 1, Fee = 65M, CreatedOn = new DateTime(2020, 3, 13) },
                    new BuildingServiceSubscription { BuildingId = 2, CompanyId = 6, Fee = 50M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 2, CompanyId = 6, Fee = 50M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 2, CompanyId = 6, Fee = 50M, CreatedOn = new DateTime(2020, 3, 13) },

                    new BuildingServiceSubscription { BuildingId = 3, CompanyId = 6, Fee = 40M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 3, CompanyId = 6, Fee = 40M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 3, CompanyId = 6, Fee = 40M, CreatedOn = new DateTime(2020, 3, 13) },

                    new BuildingServiceSubscription { BuildingId = 4, CompanyId = 3, Fee = 60M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 4, CompanyId = 3, Fee = 60M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 4, CompanyId = 3, Fee = 60M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 4, CompanyId = 4, Fee = 45M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 4, CompanyId = 4, Fee = 45M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 4, CompanyId = 4, Fee = 45M, CreatedOn = new DateTime(2020, 3, 13) },
                    new BuildingServiceSubscription { BuildingId = 4, CompanyId = 8, Fee = 25M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 4, CompanyId = 8, Fee = 25M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 4, CompanyId = 8, Fee = 25M, CreatedOn = new DateTime(2020, 3, 13) },

                    new BuildingServiceSubscription { BuildingId = 5, CompanyId = 3, Fee = 55M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 5, CompanyId = 3, Fee = 55M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 5, CompanyId = 3, Fee = 55M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 5, CompanyId = 4, Fee = 40M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 5, CompanyId = 4, Fee = 40M, CreatedOn = new DateTime(2020, 3, 13) },
                    new BuildingServiceSubscription { BuildingId = 5, CompanyId = 4, Fee = 40M, CreatedOn = new DateTime(2020, 3, 13) },

                    new BuildingServiceSubscription { BuildingId = 6, CompanyId = 4, Fee = 35M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 6, CompanyId = 4, Fee = 35M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 6, CompanyId = 4, Fee = 35M, CreatedOn = new DateTime(2020, 3, 13) },

                    new BuildingServiceSubscription { BuildingId = 7, CompanyId = 2, Fee = 53M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 7, CompanyId = 2, Fee = 53M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 7, CompanyId = 2, Fee = 53M, CreatedOn = new DateTime(2020, 3, 13) },
                    new BuildingServiceSubscription { BuildingId = 7, CompanyId = 5, Fee = 47M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 7, CompanyId = 5, Fee = 47M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 7, CompanyId = 5, Fee = 47M, CreatedOn = new DateTime(2020, 3, 13) },

                    new BuildingServiceSubscription { BuildingId = 8, CompanyId = 5, Fee = 36M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 8, CompanyId = 5, Fee = 36M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 8, CompanyId = 5, Fee = 36M, CreatedOn = new DateTime(2020, 3, 13) },

                    new BuildingServiceSubscription { BuildingId = 9, CompanyId = 5, Fee = 35M, CreatedOn = new DateTime(2020, 1, 13) },
                    new BuildingServiceSubscription { BuildingId = 9, CompanyId = 5, Fee = 35M, CreatedOn = new DateTime(2020, 2, 13) },
                    new BuildingServiceSubscription { BuildingId = 9, CompanyId = 5, Fee = 35M, CreatedOn = new DateTime(2020, 3, 13) },
                };

            buildingSubscriptions = buildingSubscriptions.Reverse<BuildingServiceSubscription>().ToList();
            foreach (var buildingSubscription in buildingSubscriptions)
            {
                await dbContext.BuildingServiceSubscriptions.AddAsync(buildingSubscription);
            }
        }
    }
}
