using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore.Library.Models
{
    class Mapper
    {
        public static Order Map(Context.Orders orders) => new Order
        {
            Id = orders.Id,
            UserName = orders.UserName,
            TotalPizza = orders.TotalPizza,
            LoName = orders.LoName,
            PizzaName = orders.PizzaName,
            TotalAmount = orders.TotalAmount,
            DatePlaced = orders.DatePlaced
        };

        public static Context.Orders Map(Order orders) => new Context.Orders
        {
            Id = orders.Id,
            UserName = orders.UserName,
            TotalPizza = orders.TotalPizza,
            LoName = orders.LoName,
            PizzaName = orders.PizzaName,
            TotalAmount = orders.TotalAmount,
            DatePlaced = orders.DatePlaced
        };

        public static Pizza Map(Context.Pizza pizza) => new Pizza
        {
            Id = pizza.Id,
            PizzaName = pizza.PizzaName,
            PizzaDesc = pizza.PizzaDesc,
            Price = pizza.Price,
            Orders = Map(pizza.Orders).ToList()
        };

        public static Context.Pizza Map(Pizza pizza) => new Context.Pizza
        {
            Id = pizza.Id,
            PizzaName = pizza.PizzaName,
            PizzaDesc = pizza.PizzaDesc,
            Price = pizza.Price,
            Orders = Map(pizza.Orders).ToList()
        };

        public static Location Map(Context.Slocation location) => new Location
        {
            Id = location.Id,
            LoName = location.LoName,
            Dough = location.Dough,
            Bacon = location.Bacon,
            Cheese = location.Cheese,
            Pepperoni = location.Pepperoni,
            Sasuage = location.Sasuage,
            Orders = Map(location.Orders).ToList(),
            Users = Map(location.Users).ToList()
        };

        public static Context.Slocation Map(Location location) => new Context.Slocation
        {
            Id = location.Id,
            LoName = location.LoName,
            Dough = location.Dough,
            Bacon = location.Bacon,
            Cheese = location.Cheese,
            Pepperoni = location.Pepperoni,
            Sasuage = location.Sasuage,
            Orders = Map(location.Orders).ToList(),
            Users = Map(location.Users).ToList()
        };

        public static User Map(Context.Users user) => new User
        {
            Id = user.Id,
            UserName = user.UserName,
            LastName = user.LastName,
            FirstName = user.FirstName,
            Password = user.Password,
            Email = user.Email,
            Phone = user.Phone,
            DefaultLo = user.DefaultLo,
            Orders = Map(user.Orders).ToList()
        };

        public static Context.Users Map(User user) => new Context.Users
        {
            Id = user.Id,
            UserName = user.UserName,
            LastName = user.LastName,
            FirstName = user.FirstName,
            Password = user.Password,
            Email = user.Email,
            Phone = user.Phone,
            DefaultLo = user.DefaultLo,
            Orders = Map(user.Orders).ToList()
        };

        public static IEnumerable<Order> Map(IEnumerable<Context.Orders> orders) => orders.Select(Map);
        public static IEnumerable<Context.Orders> Map(IEnumerable<Order> orders) => orders.Select(Map);

        public static IEnumerable<Pizza> Map(IEnumerable<Context.Pizza> pizza) => pizza.Select(Map);
        public static IEnumerable<Context.Pizza> Map(IEnumerable<Pizza> pizza) => pizza.Select(Map);

        public static IEnumerable<Location> Map(IEnumerable<Context.Slocation> location) => location.Select(Map);
        public static IEnumerable<Context.Slocation> Map(IEnumerable<Location> location) => location.Select(Map);

        public static IEnumerable<User> Map(IEnumerable<Context.Users> user) => user.Select(Map);
        public static IEnumerable<Context.Users> Map(IEnumerable<User> user) => user.Select(Map);
    }
}
