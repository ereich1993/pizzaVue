using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaVueBackend.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public string Image { get; set; }
    }
}
