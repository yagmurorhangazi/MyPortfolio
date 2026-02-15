using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.Context;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1= context.Skills.Count();
            ViewBag.v2 = context.messages.Count();
            ViewBag.v3 = context.messages.Where( x => x.Isread == false).Count();
            ViewBag.v4 = context.messages.Where( x => x.Isread == true).Count();
            ViewBag.v5= context.messages.Where(x => x.SendDate >= DateTime.Now.AddDays(-7)).Count();
            ViewBag.v6 = context.messages.OrderByDescending(x => x.SendDate).Select(x => x.SendDate).FirstOrDefault().ToShortDateString();
            ViewBag.v7 = context.messages.Select(x => x.Email).Distinct().Count();
            ViewBag.v8 = context.toDolists.Count();
            ViewBag.v9 = context.toDolists.Where(x => x.Status == true).Count();
            ViewBag.v10 = context.messages.Where(x => x.SendDate >= DateTime.Now.AddHours(-24)).Count();
            ViewBag.v11 = context.messages.GroupBy(x => x.Email).Where(g => g.Count() > 1).Count();
            ViewBag.v12 = context.messages.OrderByDescending(x => x.SendDate).Select(x => x.NameSurname).FirstOrDefault();







            return View();
        }
    }
}
