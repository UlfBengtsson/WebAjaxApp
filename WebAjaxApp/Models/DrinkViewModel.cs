using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAjaxApp.Models
{
    public class DrinkViewModel
    {
        [Required]
        [StringLength(60, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        public double Volume { get; set; }

        public bool Alcoholic { get; set; }

        public bool Carbonated { get; set; }

        public DrinkViewModel() {}
        public DrinkViewModel(Drink drink)
        {
            Name = drink.Name;
            Volume = drink.Volume;
            Alcoholic = drink.Alcoholic;
            Carbonated = drink.Carbonated;
        }
    }
}
