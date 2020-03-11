using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAjaxApp.Models;
using WebAjaxApp.Models.Services;

namespace WebAjaxApp.Controllers
{
    public class DrinksController : Controller
    {
        private readonly IDrinksService _drinksService;

        public DrinksController(IDrinksService drinksService)
        {
            _drinksService = drinksService;
        }

        // GET: Drinks
        public ActionResult Index()
        {
            return View(_drinksService.GetDrinks());
        }

        // GET: Drinks/Details/5
        public ActionResult Details(int id)
        {
            Drink drink = _drinksService.FindById(id);
            if (drink == null)
            {
                return RedirectToAction("Index");
            }
            return View(drink);
        }

        // GET: Drinks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drinks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DrinkViewModel drink)//need to have zero constructor for this binding to work
        {
            if (ModelState.IsValid)
            {
                _drinksService.Create(drink);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(drink);
            }
        }

        // GET: Drinks/Edit/5
        public ActionResult Edit(int id)
        {
            DrinkViewModel drink = new DrinkViewModel(_drinksService.FindById(id));
            if (drink == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.DrinkId = id;
            return View(drink);
        }

        // POST: Drinks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, DrinkViewModel drink)
        {

            if (ModelState.IsValid)
            {
                _drinksService.Update(id, drink);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.DrinkId = id;
                return View(drink);
            }

        }

        // GET: Drinks/Delete/5
        public ActionResult Delete(int id)
        {

            _drinksService.Remove(id);

            return RedirectToAction("Index");
        }

    }
}