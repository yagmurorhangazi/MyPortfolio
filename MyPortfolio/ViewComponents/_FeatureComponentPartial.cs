using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.Context;
using System.Linq;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
      MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {

            var values = portfolioContext.features.ToList();

            return View(values);
        }
    }
}
