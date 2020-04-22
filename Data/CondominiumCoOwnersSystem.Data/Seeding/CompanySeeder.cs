namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class CompanySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Companies.Any())
            {
                return;
            }

            var companies =
                new List<Company>()
                {
                    new Company { Name = "София Лифт", Address = "София, ул.Стражица 45", Email = "sofialift@abv.bg", CompanyTypeId = 1 },
                    new Company { Name = "Пловдив Лифт", Address = "Пловдив, ул.Кайлъшка 205", Email = "plovdivlift@abv.bg", CompanyTypeId = 1 },
                    new Company { Name = "Варна Лифт", Address = "Варна, ул. Поп Харитон 87", Email = "varnalift@abv.bg", CompanyTypeId = 1 },
                    new Company { Name = "Поли Фреш", Address = "Варна, ул.Сливница 45", Email = "cvetifresh@abv.bg", CompanyTypeId = 2 },
                    new Company { Name = "Цвети Фреш", Address = "Пловдив, ул.Подвис 1", Email = "cvetifresh@abv.bg", CompanyTypeId = 2 },
                    new Company { Name = "София Фреш", Address = "София, ул.Стрелча 4", Email = "sofiafresh@abv.bg", CompanyTypeId = 2 },
                    new Company { Name = "Цветен свят", Address = "София, ул.Подвис 113", Email = "colorgarden@abv.bg", CompanyTypeId = 3 },
                    new Company { Name = "ММ Врати", Address = "Варна, ул.Подвис 12", Email = "mmdoors@abv.bg", CompanyTypeId = 4 },
                    new Company { Name = "Гаражни Врати АД", Address = "Пловдив, ул.Прилеп 43", Email = "parkingdoors@abv.bg", CompanyTypeId = 4 },
                };

            foreach (var company in companies)
            {
                await dbContext.Companies.AddAsync(company);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
