namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Data.Models.Enums;

    public class BuildingSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Buildings.Any())
            {
                return;
            }

            var buildings =
                new List<Building>()
                        {
                          new Building { Name = "Patricia", Street = "Pop Hariton 37", PaymentMethod = PaymentMethod.CountOfApartment, CityId = 1, FundRepairId = 1, },
                          new Building { Street = "Han Malamir 4", PaymentMethod = PaymentMethod.CountOfPeople, CityId = 2, FundRepairId = 2 },
                          new Building { Name = "OrhidHills", Street = "bul. Car Osvoboditel 180", PaymentMethod = PaymentMethod.IdealParts, CityId = 3, FundRepairId = 3 },
                        };

            foreach (var building in buildings)
            {
                await dbContext.Buildings.AddAsync(building);
            }
        }
    }
}
