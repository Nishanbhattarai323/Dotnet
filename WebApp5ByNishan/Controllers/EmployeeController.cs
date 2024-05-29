using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp5ByNishan.Data;
using WebApp5ByNishan.Models;

namespace WebApp5ByNishan.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmpContext _context;

        public EmployeeController(EmpContext context)
        {
            _context = context;
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.EmpId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

       
    }
}

