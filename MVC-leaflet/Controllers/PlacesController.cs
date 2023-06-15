using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_leaflet.DB;
using MVC_leaflet.Interfaces;
using MVC_leaflet.Services;

namespace MVC_leaflet.Controllers
{
    public class PlacesController : Controller
    {
        private readonly Context _context;


        public PlacesController(Context context)
        {
            _context = context;
        }

        // GET: Places
        public async Task<IActionResult> Index()
        {
            return _context.Places != null ?
                        View(await _context.Places.ToListAsync()) :
                        Problem("Entity set 'Context.Places'  is null.");
        }

        // GET: Places/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null || _context.Places == null)
            {
                return NotFound();
            }

            var place = await _context.Places
                .FirstOrDefaultAsync(m => m.Id == id);
            if (place == null)
            {
                return NotFound();
            }

            return View(place);
        }

        private bool PlaceExists(Guid id)
        {
            return (_context.Places?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}