namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class UtilitySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Utilities.Any())
            {
                return;
            }

            var utilities =
                new List<Utility>()
                {
                    new Utility { Name = "CEZ" },
                    new Utility { Name = "EVN Bulgaria" },
                    new Utility { Name = "ENERGO-PRO" },
                    new Utility { Name = "VIK Varna" },
                    new Utility { Name = "SofiiskaVoda" },
                    new Utility { Name = "VIK Plovdiv" },
                };

            foreach (var utility in utilities)
            {
                await dbContext.Utilities.AddAsync(utility);
            }
        }
    }
}
