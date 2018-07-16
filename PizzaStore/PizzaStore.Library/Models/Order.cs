using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int? UserName { get; set; }
        public int? TotalPizza { get; set; }
        public int? LoName { get; set; }
        public int? PizzaName { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? DatePlaced { get; set; }
    }
}
