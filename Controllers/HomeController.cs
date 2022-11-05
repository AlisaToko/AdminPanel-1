using AdminPanel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext _context;
        IWebHostEnvironment _webHostEnvironment;

        public HomeController(ApplicationContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [Authorize]
        public IActionResult Index()

        {
            return View();
        }

        public async Task<IActionResult> GetAllEmployees() => View(await _context.Employees.ToListAsync());

        [HttpPost]
        public async Task<IActionResult> Create(string nameEmployee, string nameCompany)
        {
            //экземпляр класса комании
            Company company = new Company() { Name = nameCompany };
            //добавдяем в контексте applicatoncontext
            await _context.AddAsync(company);
            //сохраняем изменения
            await _context.SaveChangesAsync();
            Employee emp = new Employee() { Name = nameEmployee, Company = company };
            //тспользуем
            Employee emp2 = new Employee() { Name = "сотрудник по умолчанию", Company = company };
            await _context.AddRangeAsync(emp, emp2);
            await _context.SaveChangesAsync();

            return RedirectToAction("GetAllEmployees");
        }
    }
}
