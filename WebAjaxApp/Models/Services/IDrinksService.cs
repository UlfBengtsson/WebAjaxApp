using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAjaxApp.Models.Services
{
    public interface IDrinksService
    {
        Drink Create(DrinkViewModel drink);
        Drink FindById(int id);
        bool Update(int id, DrinkViewModel drinkViewModel);
        bool Remove(int id);
        List<Drink> GetDrinks();
    }
}
