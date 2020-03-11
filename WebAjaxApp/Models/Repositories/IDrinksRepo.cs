using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAjaxApp.Models.Repositories
{
    public interface IDrinksRepo
    {
        Drink Create(Drink drink);
        Drink FindById(int id);
        bool Update(Drink drink);
        bool Delete(int id);
        List<Drink> All();
    }
}
