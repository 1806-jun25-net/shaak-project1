using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? DefaultLo { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();


    }
}
