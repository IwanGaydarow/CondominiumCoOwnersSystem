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
                    new Service { BuildingServiceSubscriptionId = 1, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 1, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 1, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 3, 13) },
                    new Service { BuildingServiceSubscriptionId = 1, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 1, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 1, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 3, 13) },

                    new Service { BuildingServiceSubscriptionId = 2, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 2, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 2, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 3, 13) },
                    new Service { BuildingServiceSubscriptionId = 2, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 2, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 2, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 3, 13) },

                    new Service { BuildingServiceSubscriptionId = 3, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 3, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 3, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 3, 13) },

                    new Service { BuildingServiceSubscriptionId = 4, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 4, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 4, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 3, 13) },
                    new Service { BuildingServiceSubscriptionId = 4, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 4, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 4, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 3, 13) },
                    new Service { BuildingServiceSubscriptionId = 4, Description = "Поддръжка на гаражна врата.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 4, Description = "Поддръжка на гаражна врата.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 4, Description = "Поддръжка на гаражна врата.", CreatedOn = new DateTime(2020, 3, 13) },

                    new Service { BuildingServiceSubscriptionId = 5, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 5, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 5, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 3, 13) },
                    new Service { BuildingServiceSubscriptionId = 5, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 5, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 5, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 3, 13) },

                    new Service { BuildingServiceSubscriptionId = 6, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 6, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 6, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 3, 13) },

                    new Service { BuildingServiceSubscriptionId = 7, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 7, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 7, Description = "Поддръжка на асансъора.", CreatedOn = new DateTime(2020, 3, 13) },
                    new Service { BuildingServiceSubscriptionId = 7, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 7, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 7, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 3, 13) },

                    new Service { BuildingServiceSubscriptionId = 8, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 8, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 8, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 3, 13) },

                    new Service { BuildingServiceSubscriptionId = 9, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 1, 13) },
                    new Service { BuildingServiceSubscriptionId = 9, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 2, 13) },
                    new Service { BuildingServiceSubscriptionId = 9, Description = "Почистване на общите части.", CreatedOn = new DateTime(2020, 3, 13) },
                };

            foreach (var service in services)
            {
                await dbContext.Services.AddAsync(service);
            }
        }
    }
}
