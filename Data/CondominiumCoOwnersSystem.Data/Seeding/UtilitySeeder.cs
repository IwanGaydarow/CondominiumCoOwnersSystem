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
                    new Utility { Name = "ЧЕЗ" },
                    new Utility { Name = "ЕВН" },
                    new Utility { Name = "ЕНЕРГО-ПРО" },
                    new Utility { Name = "ВиК Варна" },
                    new Utility { Name = "Софийска Вода" },
                    new Utility { Name = "ВиК Пловдив" },
                };

            foreach (var utility in utilities)
            {
                await dbContext.Utilities.AddAsync(utility);
            }
        }
    }
}
