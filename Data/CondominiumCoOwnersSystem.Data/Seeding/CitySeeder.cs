namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class CitySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Cities.Any())
            {
                return;
            }

            var cities =
                new List<City>
                {
                    new City { Name = "София" },
                    new City { Name = "Варна" },
                    new City { Name = "Пловдив" },
                };

            foreach (var city in cities)
            {
                await dbContext.Cities.AddAsync(city);
            }
        }
    }
}
