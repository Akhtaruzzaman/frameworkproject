using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RazorPagesContacts.Data;

namespace Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public  async Task<IActionResult>  ApiData()
        {
            var s =await _db.Information.ToListAsync();
            return View(s);
        }
        public IActionResult Create()
        {
            Information.Information information = new Information.Information();
            return View(information);
        }
        [HttpPost]
        public IActionResult Create(Information.Information info)
        {
            if (ModelState.IsValid)
            {
                var result = _db.Add(info);
                _db.SaveChanges();
            }
            return RedirectToAction("ApiData");
        }
        public IActionResult Edit(int id)
        {
            Information.Information information = new Information.Information();
            information = _db.Information.Find(id);
            return View(information);
        }
        [HttpPost]
        public IActionResult Edit(Information.Information info)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(info).State = EntityState.Modified;
                _db.SaveChanges();
            }
            return RedirectToAction("ApiData");
        }
        public IActionResult Details(int id)
        {
            Information.Information information = new Information.Information();
            information = _db.Information.Find(id);
            return View(information);
        }
        public IActionResult Delete(int id)
        {
            var info = _db.Information.Find(id);
            if (info != null)
            {
                var result = _db.Information.Remove(info);
                _db.SaveChanges();
            }
            return RedirectToAction("ApiData");
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
