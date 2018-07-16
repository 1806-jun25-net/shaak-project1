using Microsoft.EntityFrameworkCore;
using PizzaStore.Context;
using PizzaStore.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore.Library.Repositories
{
    class PizzaStoreRepository
    {
        private readonly PizzaAppDBContext _db;

        public PizzaStoreRepository(PizzaAppDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public IEnumerable<Models.Order> GetOrders(string search = null)
        {
            if (search == null)
            {
                return Mapper.Map(_db.Orders.Include(u => u.UserName));
            }
            else
            {
                return Mapper.Map(_db.Orders.Include(u => u.UserName).AsNoTracking().Where(u => u..Contains(search)));
            }
        }

        public Models.Order GetOrderById(int id)
        {
            return Mapper.Map(_db.Orders.Include(x => x.PizzaName).AsNoTracking().First(x => x.Id == id));
        }

        public Users GetUserByName(string First, string Last)
        {
            var users = _db.Users;
            var username = new User();

            //querries database to find username of first and last name 
            // IQueryable<Users> user = _db.Users.Where(n => n.FirstName == First && n.LastName == Last);

            foreach (var person in users)
            {
                if (person.FirstName == First && person.LastName == Last)
                    username = Mapper.Map(person);
            }

            return Mapper.Map(username);
        }

        public IEnumerable<Orders> GetRecentOrder(string user)
        {
            List<Orders> orders = _db.Orders.Take(1).Where(x => x.UserName == user).OrderByDescending(u => u.OrderId).Select(x => x).ToList();
            return orders;
        }

        public void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Orders> GetOrderByUserCheap(string user)
        {
            List<Orders> orders = _db.Orders.AsNoTracking().Where(x => x.UserName == user).OrderBy(u => u.TotalAmount).Select(x => x).ToList();
            return orders;
        }

        public IEnumerable<Orders> GetOrderByUserExpensive(string user)
        {
            List<Orders> orders = _db.Orders.AsNoTracking().Where(x => x.UserName == user).OrderByDescending(u => u.TotalAmount).Select(x => x).ToList();
            return orders;
        }

        public IEnumerable<Orders> GetOrderByUserHistory(string user)
        {
            List<Orders> orders = _db.Orders.AsNoTracking().Where(x => x.UserName == user).OrderBy(u => u.OrderId).Select(x => x).ToList();
            return orders;
        }

        public IEnumerable<Orders> GetOrderByUserRecent(string user)
        {
            List<Orders> orders = _db.Orders.AsNoTracking().Where(x => x.UserName == user).OrderByDescending(u => u.OrderId).Select(x => x).ToList();
            return orders;
        }

        public IEnumerable<Orders> GetOrderByLocationCheap(string location)
        {
            List<Orders> orders = _db.Orders.AsNoTracking().Where(x => x.LoName == location).OrderBy(u => u.TotalAmount).Select(x => x).ToList();
            return orders;
        }

        public IEnumerable<Orders> GetOrderByLocationExpensive(string location)
        {
            List<Orders> orders = _db.Orders.AsNoTracking().Where(x => x.LoName == location).OrderByDescending(u => u.TotalAmount).Select(x => x).ToList();
            return orders;
        }

        public IEnumerable<Orders> GetOrderByLocationHistory(string location)
        {
            List<Orders> orders = _db.Orders.AsNoTracking().Where(x => x.LoName == location).OrderBy(u => u.OrderId).Select(x => x).ToList();
            return orders;
        }

        public IEnumerable<Orders> GetOrderByLocationRecent(string location)
        {
            List<Orders> orders = _db.Orders.AsNoTracking().Where(x => x.LoName == location).OrderByDescending(u => u.OrderId).Select(x => x).ToList();
            return orders;
        }

        public void AddOrder(Orders order)
        {
            _db.Add(order);
            _db.SaveChanges();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
