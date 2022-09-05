using CheckboxTest.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckboxTest.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View(123);
        }

        public ActionResult Viewer() {
            return View();
        }
        // GET: PatientAllergy
        public ActionResult Edit(int id, bool isReadOnly = false) // id = episodeId
        {
            var patientId = 987;

            return PartialView(new EditAllergiesModel
            {
                PatientId = patientId,
                EpisodeId = id,
                IsReadOnly = isReadOnly,
                HasNoKnownDrugAllergies = false
            });
        }

        [HttpPost]
        public ActionResult Edit(int id, EditAllergiesModel model) // id = PatientId
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine("Testing");
            }

            return PartialView(model);
        }

    }
}