using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestClusterProj.Models;

namespace TestClusterProj.Controllers
{
    public class WgeAmrtamperStagingController : Controller
    {
        private readonly ClusterContext _context;

        public WgeAmrtamperStagingController(ClusterContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.WgeAmrtamperStagings.ToListAsync();
            return View(data);
        }
    }
}
