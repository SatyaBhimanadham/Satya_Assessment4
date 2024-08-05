using AssesmentOnEF.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AssesmentOnEF.Controllers
{
    public class CompanyController : Controller
    {
        private readonly Asses3Context obj;
        public CompanyController()
        {
            obj = new Asses3Context();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var company = obj.Companies;
            return View(company);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                obj.Companies.Add(company);
                obj.SaveChanges();
                return View("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
