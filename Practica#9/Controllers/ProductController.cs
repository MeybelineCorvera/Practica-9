using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practica_9.Context;
using Practica_9.Models;

namespace Practica_9.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }
    }
}


