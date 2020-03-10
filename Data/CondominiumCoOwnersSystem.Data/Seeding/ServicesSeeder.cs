namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class ServicesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Services.Any())
            {
                return;
            }

            var services =
                new List<Service>()
                {
                    new Service { Description = "Cleaning common parts in building", BuildingServiceSubscriptionId = 1 },
                    new Service { Description = "Cheks if lift work corectly", BuildingServiceSubscriptionId = 2 },
                    new Service { Description = "Cleaning common parts without basemant steps", BuildingServiceSubscriptionId = 3 },
                };

            foreach (var service in services)
            {
                await dbContext.Services.AddAsync(service);
            }
        }
    }
}
