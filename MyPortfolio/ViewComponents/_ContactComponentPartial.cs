using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial: ViewComponent

    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.contactsTitle = context.contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.contactsDescription = context.contacts.Select(x => x.Description).FirstOrDefault();
            ViewBag.contactsPhone1 = context.contacts.Select(x => x.Phone1).FirstOrDefault();
            ViewBag.contactsPhone2 = context.contacts.Select(x => x.Phone2).FirstOrDefault();
            ViewBag.contactsEmail1 = context.contacts.Select(x => x.Email1).FirstOrDefault();
            ViewBag.contactsEmail2 = context.contacts.Select(x => x.Email2).FirstOrDefault();
            ViewBag.contactsAddress = context.contacts.Select(x => x.Address).FirstOrDefault();
            return View();
        }
    }
}
