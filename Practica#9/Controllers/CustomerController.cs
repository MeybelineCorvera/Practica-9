using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practica_9.Context;

namespace Practica_9.Controllers
{
    public class CustomerController : Controller
    {

        private readonly AppDbContext _context;

        public CustomerController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var customers = await _context.Customers.Include(c => c.Orders).ToListAsync();
            return View(customers);
        }
    }
}
