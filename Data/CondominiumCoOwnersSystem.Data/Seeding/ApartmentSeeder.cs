namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class ApartmentSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Apartments.Any())
            {
                return;
            }

            //await dbContext.Apartments.AddAsync(
            //    new Apartment { BuildingId = 2, Floor = 2, Number = 14, UserId = "a1aa327e-346b-48b9-8c4f-aeca9922c8b0" });
        }
    }
}
