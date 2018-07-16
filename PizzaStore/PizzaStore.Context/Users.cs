using System;
using System.Collections.Generic;

namespace PizzaStore.Context
{
    public partial class Users
    {
        public Users()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? DefaultLo { get; set; }

        public Slocation DefaultLoNavigation { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
