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
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 1, Fee = 45M },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 2, Fee = 50M },
                    new CompanyMontlyServiceFee { BuildingServiceSubscriptionId = 3, Fee = 40M },
                };

            foreach (var montlyFee in montlyFees)
            {
                await dbContext.CompanyMontlyServiceFees.AddAsync(montlyFee);
            }
        }
    }
}
