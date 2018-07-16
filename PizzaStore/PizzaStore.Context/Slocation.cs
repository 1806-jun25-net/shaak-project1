using System;
using System.Collections.Generic;

namespace PizzaStore.Context
{
    public partial class Slocation
    {
        public Slocation()
        {
            Orders = new HashSet<Orders>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string LoName { get; set; }
        public int? Dough { get; set; }
        public int? Bacon { get; set; }
        public int? Cheese { get; set; }
        public int? Pepperoni { get; set; }
        public int? Sasuage { get; set; }

        public ICollection<Orders> Orders { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
