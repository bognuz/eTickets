using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {

        private readonly AppDbContext _Context;

        public CinemasController(AppDbContext context)
        {
            _Context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _Context.Producers.ToListAsync();
            return View();
        }
    }
}

