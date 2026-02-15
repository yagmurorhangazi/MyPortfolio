using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.Dal.Context;

namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values = context.messages.ToList();
            return View(values);
        }

        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = context.messages.Find(id);
            value.Isread = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

            public IActionResult ChangeIsReadToFalse(int id)
            {
                var value = context.messages.Find(id);
                value.Isread = false;
                context.SaveChanges();
                return RedirectToAction("Inbox");
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = context.messages.Find(id);
            context.messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult MessageDetails(int id)
        {
            var value = context.messages.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult SendMessage(MyPortfolio.Dal.Entities.Message message)
        {
           
            message.SendDate = DateTime.Now;
            message.Isread = false;

            
            context.messages.Add(message);

            
            context.SaveChanges();

            
            return RedirectToAction("Index", "Default");
        }


    }
}
