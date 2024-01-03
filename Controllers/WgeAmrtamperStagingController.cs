using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestClusterProj.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace TestClusterProj.Controllers
{
    public class WgeAmrtamperStagingController : Controller
    {
        private readonly ClusterContext _context;

        public WgeAmrtamperStagingController(ClusterContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(DateTime? startDate, DateTime? endDate)
        {
            var query = _context.WgeAmrtamperStagings.AsQueryable();

            if (startDate.HasValue)
            {
                query = query.Where(x => x.DiscTime >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(x => x.DiscTime <= endDate.Value);
            }

            // Sorting by DiscTime in descending order
            query = query.OrderByDescending(x => x.DiscTime);

            var data = await query.ToListAsync();
            return View(data);
        }

        }
    }
