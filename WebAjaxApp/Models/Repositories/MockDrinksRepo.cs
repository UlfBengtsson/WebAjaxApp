using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAjaxApp.Models.Repositories
{
    public class MockDrinksRepo : IDrinksRepo
    {
        private static List<Drink> drinks = new List<Drink>();
        private static int idCounter = 0;

        public List<Drink> All()
        {
            return drinks;
        }

        public Drink Create(Drink drink)
        {
            drink.Id = ++idCounter;
            drinks.Add(drink);
            return drink;
        }

        public bool Delete(int id)
        {
            Drink drink = FindById(id);
            if (drink == null)
            {
                return false;
            }
            else
            {
                return drinks.Remove(drink);
            }
        }

        public Drink FindById(int id)
        {
            Drink drink = drinks.SingleOrDefault(d => d.Id == id);

            return drink;
        }

        public bool Update(Drink drink)
        {
            Drink original = FindById(drink.Id);
            if (drink == null)
            {
                return false;
            }
            else
            {
                original.Name = drink.Name;
                original.Volume = drink.Volume;
                original.Alcoholic = drink.Alcoholic;
                original.Carbonated = drink.Carbonated;

                return true;
            }
        }
    }
}
