using Microsoft.AspNetCore.Mvc;
using Synergy_Health.Data;
using Synergy_Health.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Synergy_Health.Controllers
{
    public class NurseController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public NurseController(ApplicationDbContext dBD)
        {
            dbContext = dBD;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddVital()
        {
            //List<SelectListItem> a = new List<SelectListItem>();
            //a = dbContext.vitals.Select(x => new SelectListItem { Text = x.Temperature.ToString(), Value = x.VitalID.ToString() }).ToList();
            //ViewBag.Vital = a;
            return View();
        }

        public IActionResult EditVital()
        {
            return View();
        }

        public IActionResult DeleteVital()
        {
            return View();
        }

        public IActionResult ListVital()
        {
            return View();
        }
    }
}
