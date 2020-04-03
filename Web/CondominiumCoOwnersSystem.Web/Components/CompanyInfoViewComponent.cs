namespace CondominiumCoOwnersSystem.Web.Components
{
    using CondominiumCoOwnersSystem.Services.Data;
    using CondominiumCoOwnersSystem.Web.ViewModels.CompanyInfo;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    public class CompanyInfoViewComponent : ViewComponent
    {
        private readonly IReportsService reportService;

        public CompanyInfoViewComponent(IReportsService reportService)
        {
            this.reportService = reportService;
        }

        public IViewComponentResult Invoke(int companyId)
        {
            var companyInfo = this.reportService.GetCompanyInfoById<CompanyInfoViewModel>(companyId);
            return this.View(companyInfo);
        }
    }
}
