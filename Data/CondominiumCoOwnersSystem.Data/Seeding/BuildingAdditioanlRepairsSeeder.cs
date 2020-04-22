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
                    new BuildingAdditionalRepairs
                    {
                        BuildingId = 1, CreatedOn = new DateTime(2020, 2, 13, 13, 32, 12),
                        Cost = 56.54M, Description = "Смяна на осветителни тела.", MadeBy = "EURO Light",
                    },

                    new BuildingAdditionalRepairs
                    {
                        BuildingId = 2, CreatedOn = new DateTime(2020, 1, 13, 13, 32, 12),
                        Cost = 90M, Description = "Ремонт на парапет.", MadeBy = "Парапети София",
                    },

                    new BuildingAdditionalRepairs
                    {
                        BuildingId = 3, CreatedOn = new DateTime(2020, 2, 13, 13, 32, 12),
                        Cost = 50M, Description = "Годишен технически преглед.", MadeBy = "София Лифт",
                    },

                    new BuildingAdditionalRepairs
                    {
                        BuildingId = 4, CreatedOn = new DateTime(2020, 3, 13, 13, 32, 12),
                        Cost = 45M, Description = "Почистване на подземен паркинг", MadeBy = "Поли Фреш",
                    },

                    new BuildingAdditionalRepairs
                    {
                        BuildingId = 5, CreatedOn = new DateTime(2020, 2, 13, 13, 32, 12),
                        Cost = 45M, Description = "Сим карта за разговорно устройство.", MadeBy = "А1",
                    },

                    new BuildingAdditionalRepairs
                    {
                        BuildingId = 6, CreatedOn = new DateTime(2020, 3, 13, 13, 32, 12),
                        Cost = 36.20M, Description = "Смяна на осветителни тела.", MadeBy = "Вход помощник",
                    },

                    new BuildingAdditionalRepairs
                    {
                        BuildingId = 7, CreatedOn = new DateTime(2020, 2, 13, 13, 32, 12),
                        Cost = 65M, Description = "Годишен технически преглед.", MadeBy = "Пловдив Лифт",
                    },

                    new BuildingAdditionalRepairs
                    {
                        BuildingId = 8, CreatedOn = new DateTime(2020, 1, 13, 13, 32, 12),
                        Cost = 34.33M, Description = "Ремонт пощенски кутий", MadeBy = "Думофони Пловдив",
                    },

                    new BuildingAdditionalRepairs
                    {
                        BuildingId = 9, CreatedOn = new DateTime(2020, 2, 13, 13, 32, 12),
                        Cost = 38M, Description = "Смяна на плафон", MadeBy = "EURO Light",
                    },
                };

            foreach (var buildingAddRepair in buildingAdditioanRepairs)
            {
                await dbContext.BuildingAdditionalRepairs.AddAsync(buildingAddRepair);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
