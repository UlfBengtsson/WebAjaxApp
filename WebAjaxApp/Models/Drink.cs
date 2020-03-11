using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAjaxApp.Models
{
    public class Drink
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double Volume { get; set; }
        public bool Alcoholic { get; set; }
        public bool Carbonated { get; set; }
    }
}
