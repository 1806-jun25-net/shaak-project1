using System;
using System.Collections.Generic;

namespace PizzaStore.Context
{
    public partial class Pizza
    {
        public Pizza()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string PizzaName { get; set; }
        public string PizzaDesc { get; set; }
        public decimal? Price { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
