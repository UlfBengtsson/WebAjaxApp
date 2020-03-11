using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAjaxApp.Models;
using WebAjaxApp.Models.Services;

namespace WebAjaxApp.Controllers
{
    public class AjaxDrinksController : Controller
    {

        private readonly IDrinksService _drinksService;

        public AjaxDrinksController(IDrinksService drinksService)
        {
            _drinksService = drinksService;
        }

        public IActionResult SPA()
        {
            return View(_drinksService.GetDrinks());
        }

        // GET
        public ActionResult Delete(int id)
        {

            if(_drinksService.Remove(id))
            {
                return Content("was deleted");
            }
            else
            {
                return NotFound();
            }

            
        }

        [HttpPost]
        public ActionResult Create(DrinkViewModel drink)//need to have zero constructor for this binding to work
        {
            if (ModelState.IsValid)
            {
                Drink createdDrink = _drinksService.Create(drink);

                return PartialView("_drinkPartial", createdDrink);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}