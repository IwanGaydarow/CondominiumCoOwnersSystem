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
                          new Building { Street = "бул.Съборни 185", PaymentMethod = PaymentMethod.CountOfApartment, CityId = 1, FundRepairId = 1 },
                          new Building { Street = "ул.Беласица 27", PaymentMethod = PaymentMethod.IdealParts, CityId = 1, FundRepairId = 2 },
                          new Building { Street = "ул.Тинтява 150", PaymentMethod = PaymentMethod.CountOfPeople, CityId = 1, FundRepairId = 3 },
                          new Building { Street = "ул.Поп Харитон 37", PaymentMethod = PaymentMethod.CountOfApartment, CityId = 2, FundRepairId = 4 },
                          new Building { Street = "бул.Сливница 187", PaymentMethod = PaymentMethod.CountOfPeople, CityId = 2, FundRepairId = 5 },
                          new Building { Street = "ул.Балкапан 3", PaymentMethod = PaymentMethod.IdealParts, CityId = 2, FundRepairId = 6 },
                          new Building { Street = "кв.Тракиа Бл.35", PaymentMethod = PaymentMethod.CountOfApartment, CityId = 3, FundRepairId = 7 },
                          new Building { Street = "ул. Пловдив 105", PaymentMethod = PaymentMethod.CountOfPeople, CityId = 3, FundRepairId = 8 },
                          new Building { Street = "ул.Шипка 20", PaymentMethod = PaymentMethod.IdealParts, CityId = 3, FundRepairId = 9 },
                        };

            foreach (var building in buildings)
            {
                await dbContext.Buildings.AddAsync(building);
            }
        }
    }
}
