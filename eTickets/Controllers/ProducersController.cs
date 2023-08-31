using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _Context;

        public ProducersController(AppDbContext context)
        {
           _Context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _Context.Producers.ToListAsync();
            return View();
        }
    }
}
