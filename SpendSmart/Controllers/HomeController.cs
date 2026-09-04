using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using SpendSmart.Models;
using System.Diagnostics;

namespace SpendSmart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expenses()
        {
            return View();
        }

        //Metoden får samma namn som view
        public IActionResult CreateEditExpense()
        {
            return View();
        }

        //För att formuläret ska skickas någonstans när man trycker på OK
        //Objekt av typen Expense
        public IActionResult CreateEditExpenseForm(Expense model)
        {
            //Återvänder till startsidan
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
