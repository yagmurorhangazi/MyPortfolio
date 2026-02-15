using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.Context;
using MyPortfolio.Dal.Entities;

namespace MyPortfolio.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.toDolists.ToList();
            return View(values);
        }

        [HttpGet]

        public IActionResult CreateToDoList()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.toDolists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult DeleteToDoList(int id)
        {
            var values = context.toDolists.Find(id);
            context.toDolists.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult UpdateToDoList(int id)
        {
            var values = context.toDolists.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            context.toDolists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToDoListStatusToTrue(int id)
        {
            var value = context.toDolists.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToFalse(int id)
        {
            var value = context.toDolists.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
