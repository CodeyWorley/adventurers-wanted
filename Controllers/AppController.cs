using AdventurersWanted.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventurersWanted.Controllers
{
    public class AppController : Controller
    {
        private readonly EntityContext _context;

        public AppController(EntityContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("campaign-search")]
        public IActionResult CampaignSearch()
        {
            var results = _context.Campaigns.ToList();
            return View(results);
        }

        [HttpGet("profile")]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
