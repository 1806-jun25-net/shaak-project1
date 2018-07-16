using System;
using System.Collections.Generic;

namespace PizzaStore.Context
{
    public partial class Orders
    {
        public int Id { get; set; }
        public int? UserName { get; set; }
        public int? TotalPizza { get; set; }
        public int? LoName { get; set; }
        public int? PizzaName { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? DatePlaced { get; set; }

        public Slocation LoNameNavigation { get; set; }
        public Pizza PizzaNameNavigation { get; set; }
        public Users UserNameNavigation { get; set; }
    }
}
