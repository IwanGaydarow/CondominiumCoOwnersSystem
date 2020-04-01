namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class CompanyMontlyServiceFeeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.CompanyMontlyServiceFees.Any())
            {
                return;
            }

            var montlyFees =
                new List<CompanyMontlyServiceFee>()
                {
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 1, Fee = 65M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 1, Fee = 65M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 1, Fee = 65M, CreatedOn = new DateTime(2020, 3, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 1, Fee = 45M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 1, Fee = 45M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 1, Fee = 45M, CreatedOn = new DateTime(2020, 3, 12) },

                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 2, Fee = 65M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 2, Fee = 65M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 2, Fee = 65M, CreatedOn = new DateTime(2020, 3, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 2, Fee = 50M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 2, Fee = 50M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 2, Fee = 50M, CreatedOn = new DateTime(2020, 3, 12) },

                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 3, Fee = 40M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 3, Fee = 40M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 3, Fee = 40M, CreatedOn = new DateTime(2020, 3, 12) },

                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 4, Fee = 60M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 4, Fee = 60M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 4, Fee = 60M, CreatedOn = new DateTime(2020, 3, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 4, Fee = 45M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 4, Fee = 45M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 4, Fee = 45M, CreatedOn = new DateTime(2020, 3, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 4, Fee = 25M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 4, Fee = 25M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 4, Fee = 25M, CreatedOn = new DateTime(2020, 3, 12) },

                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 5, Fee = 55M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 5, Fee = 55M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 5, Fee = 55M, CreatedOn = new DateTime(2020, 3, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 5, Fee = 40M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 5, Fee = 40M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 5, Fee = 40M, CreatedOn = new DateTime(2020, 3, 12) },

                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 6, Fee = 35M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 6, Fee = 35M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 6, Fee = 35M, CreatedOn = new DateTime(2020, 3, 12) },

                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 7, Fee = 53M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 7, Fee = 53M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 7, Fee = 53M, CreatedOn = new DateTime(2020, 3, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 7, Fee = 47M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 7, Fee = 47M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 7, Fee = 47M, CreatedOn = new DateTime(2020, 3, 12) },

                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 8, Fee = 36M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 8, Fee = 36M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 8, Fee = 36M, CreatedOn = new DateTime(2020, 3, 12) },

                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 9, Fee = 35M, CreatedOn = new DateTime(2020, 1, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 9, Fee = 35M, CreatedOn = new DateTime(2020, 2, 12) },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 9, Fee = 35M, CreatedOn = new DateTime(2020, 3, 12) },
                };

            foreach (var montlyFee in montlyFees)
            {
                await dbContext.CompanyMontlyServiceFees.AddAsync(montlyFee);
            }
        }
    }
}
