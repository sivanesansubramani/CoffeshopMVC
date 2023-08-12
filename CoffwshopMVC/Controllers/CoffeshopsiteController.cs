using CoffwshopMVC.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffwshopMVC.Repository;
using CoffwshopMVC.Models;

namespace CoffwshopMVC.Controllers
{
    public class CoffeshopsiteController : Controller
    {
        // GET: CoffeshopsiteController



        ReservationTable ObjRepository;

        public CoffeshopsiteController()
        {
            ObjRepository = new ReservationTable();
        }



        public ActionResult List()
        {
            return View("ReservatioTable", ObjRepository.Select());
        }




        // GET: PersonalDataController/Create
        public ActionResult InsertRecord()
        {
            return View("Reservation", new ReservationModel());
        }

        // POST: PersonalDataController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservationModel data)
        {
            try
            {
                ObjRepository.InsertPersonalData(data);
                return RedirectToAction();
            }
            catch
            {
                return View();
            }
        }




        public ActionResult About()
        {
            return View();
        }


        public ActionResult Home()
        {
            return View();
        }

        public ActionResult menu()
        {
            return View();
        }

        public ActionResult Reservation()
        {
            return View();
        }

        public ActionResult Service()
        {
            return View();
        }

        public ActionResult Testimonial()
        {
            return View();
        }


        public ActionResult Contact()
        {
            return View();
        }



        

        // GET: CoffeshopsiteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CoffeshopsiteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoffeshopsiteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CoffeshopsiteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CoffeshopsiteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CoffeshopsiteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CoffeshopsiteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
