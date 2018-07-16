using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.WebApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int TotalPizza { get; set; }
        public string LoName { get; set; }
        public string PizzaName { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime DatePlaced { get; set; }
        public DateTime TimePlaced { get; set; }

    }
}
