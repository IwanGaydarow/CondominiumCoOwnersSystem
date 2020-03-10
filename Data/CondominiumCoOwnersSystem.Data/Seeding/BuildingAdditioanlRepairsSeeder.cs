namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class BuildingAdditioanlRepairsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.BuildingAdditionalRepairs.Any())
            {
                return;
            }

            var buildingAdditioanRepairs =
                new List<BuildingAdditionalRepairs>()
                {
                    new BuildingAdditionalRepairs { BuildingId = 1, Cost = 140.76M, Description = "Changed lighting.", MadeBy = "EURO Light" },
                    new BuildingAdditionalRepairs { BuildingId = 2, Cost = 45M, Description = "Repair of railing in floor 3", MadeBy = "Stanislav Petrov" },
                    new BuildingAdditionalRepairs { BuildingId = 3, Cost = 30M, Description = "Changed glass in parter floor", MadeBy = "Peter Ivanov" },
                };

            foreach (var buildingAddRepair in buildingAdditioanRepairs)
            {
                await dbContext.BuildingAdditionalRepairs.AddAsync(buildingAddRepair);
            }
        }
    }
}
