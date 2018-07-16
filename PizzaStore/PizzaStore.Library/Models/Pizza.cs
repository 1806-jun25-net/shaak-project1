using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public string PizzaDesc { get; set; }
        public decimal? Price { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
