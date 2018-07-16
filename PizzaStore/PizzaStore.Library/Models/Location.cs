using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string LoName { get; set; }
        public int? Dough { get; set; }
        public int? Bacon { get; set; }
        public int? Cheese { get; set; }
        public int? Pepperoni { get; set; }
        public int? Sasuage { get; set; }

        public List<User> Users { get; set; } = new List<User>();
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
