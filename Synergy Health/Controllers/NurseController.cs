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
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddVital(Vital vital)
        {
            if (!ModelState.IsValid)
            {
                return View(vital);
            }

            dbContext.vitals.Add(vital);
            dbContext.SaveChanges();
            return RedirectToAction("ListVital");
        }

        public IActionResult EditVital(int id)
        {
            var model = dbContext.vitals.SingleOrDefault(c => c.VitalID == id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditVital(int id, Vital vitals)
        {
            if (!ModelState.IsValid)
            {
                return View(vitals);
            }

            var vital = dbContext.vitals.Single(c => c.VitalID == id);
            vitals.Weight = vital.Weight;
            vitals.BloodPressure = vital.BloodPressure;
            vitals.Date = vital.Date;
            vitals.HeartRate = vital.HeartRate;
            vitals.Temperature = vital.Temperature;
            vitals.Notes = vital.Notes;

            dbContext.SaveChanges();
            return RedirectToAction("ListVital");
        }
        public IActionResult DeleteVital(int? id)
        {
            var vital = dbContext.vitals.Single(c => c.VitalID == id);
            return View(vital);
        }
        [HttpPost, ActionName("DeleteVital")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteVital(int id)
        {
            var vital = dbContext.vitals.SingleOrDefault(c => c.VitalID == id);
            dbContext.vitals.Remove(vital);
            dbContext.SaveChanges();
            return RedirectToAction("ListVital");
        }
        public IActionResult ListVital()
        {
            var vital = dbContext.vitals.ToList();
            return View(vital);
        }

        //Treatment

        public IActionResult AddTreatment()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddTreatment(Treatment treatment)
        {
            if (!ModelState.IsValid)
            {
                return View(treatment);
            }

            dbContext.treatments.Add(treatment);
            dbContext.SaveChanges();
            return RedirectToAction("ListTreatment");
        }

        public IActionResult EditTreatment(int id)
        {
            var model = dbContext.treatments.SingleOrDefault(c => c.TreatmentID == id);
            return View(model);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult EditTreatment(int id, Treatment treatment)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(treatment);
        //    }

        //    var treatment = dbContext.treatments.Single(c => c.TreatmentID == id);
        //    treatment.Weight = treatment.Weight;
        //    treatment.BloodPressure = treatment.BloodPressure;
        //    treatment.Date = treatment.Date;
        //    treatment.HeartRate = treatment.HeartRate;
        //    treatment.Temperature = treatment.Temperature;
        //    treatment.Notes = treatment.Notes;

        //    dbContext.SaveChanges();
        //    return RedirectToAction("ListTreatment");
        //}
        public IActionResult DeleteTreatment(int? id)
        {
            var vital = dbContext.treatments.Single(c => c.TreatmentID == id);
            return View(vital);
        }

        [HttpPost, ActionName("DeleteTreatment")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteTreatment(int id)
        {
            var treatment = dbContext.treatments.SingleOrDefault(c => c.TreatmentID == id);
            dbContext.treatments.Remove(treatment);
            dbContext.SaveChanges();
            return RedirectToAction("ListTreatment");
        }


        public IActionResult ListTreatment()
        {
            var treatment = dbContext.vitals.ToList();
            return View(treatment);
        }
    }
}
