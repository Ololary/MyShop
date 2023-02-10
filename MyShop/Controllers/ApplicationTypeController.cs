﻿using Microsoft.AspNetCore.Mvc;

namespace MyShop.Controllers
{
    public class ApplicationTypeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ApplicationTypeController(ApplicationDbContext db)
        {   
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ApplicationType>? objList = _db.ApplicationType;
            return View(objList);
        }
        //Get create
        public IActionResult Create()
        {
            return View();
        }

        //Post create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType obj)
        {
            _db.ApplicationType.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}