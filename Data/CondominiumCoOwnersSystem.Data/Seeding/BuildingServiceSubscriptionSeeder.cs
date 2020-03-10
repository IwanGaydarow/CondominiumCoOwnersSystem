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
                    new BuildingServiceSubscription { BuildingId = 1, CompanyId = 2, Fee = 45M },
                    new BuildingServiceSubscription { BuildingId = 2, CompanyId = 1, Fee = 50M },
                    new BuildingServiceSubscription { BuildingId = 3, CompanyId = 3, Fee = 40M },
                };

            foreach (var buildingSubscription in buildingSubscriptions)
            {
                await dbContext.BuildingServiceSubscriptions.AddAsync(buildingSubscription);
            }
        }
    }
}
