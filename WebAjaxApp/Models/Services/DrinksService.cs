using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAjaxApp.Models.Repositories;

namespace WebAjaxApp.Models.Services
{
    public class DrinksService : IDrinksService
    {
        private readonly IDrinksRepo _drinksRepo;

        public DrinksService(IDrinksRepo drinksRepo)
        {
            _drinksRepo = drinksRepo;
        }

        public Drink Create(DrinkViewModel drink)
        {
            return _drinksRepo.Create(VM_ToDrink(drink));
        }

        public Drink FindById(int id)
        {
            return _drinksRepo.FindById(id);
        }

        public List<Drink> GetDrinks()
        {
            return _drinksRepo.All();
        }

        public bool Remove(int id)
        {
            return _drinksRepo.Delete(id);
        }

        public bool Update(int id, DrinkViewModel drinkViewModel)
        {
            Drink drink = VM_ToDrink(drinkViewModel);
            drink.Id = id;
            return _drinksRepo.Update(drink);
        }

        private Drink VM_ToDrink(DrinkViewModel drinkViewModel)
        {
            return new Drink() { Name = drinkViewModel.Name, Volume = drinkViewModel.Volume, Alcoholic = drinkViewModel.Alcoholic, Carbonated = drinkViewModel.Carbonated };
        }
    }
}
