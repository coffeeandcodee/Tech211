using Microsoft.EntityFrameworkCore;
using NorthwindData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBusiness
{
    public class CustomerService : ICustomerService, IDisposable
    {
        private NorthwindContext _db;

        public CustomerService(NorthwindContext context)
        {
            _db = context;
        }

        public CustomerService()
        {
            _db = new NorthwindContext();
        }

        public void Create(Customer c)
        {
            _db.Customers.Add(c);
            _db.SaveChanges();

        }

        public Customer Read(string customerId)
        {
            var c = _db.Customers.Find(customerId);
            if (c is null) throw new ArgumentException($"{customerId} is not a valid CustomerID");
            else return c;
        }

        public bool Update(Customer c)
        {   
            bool exists = _db.Customers.Any(customer => customer.CustomerId == c.CustomerId);
            var selectedCustomer = _db.Customers.Find(c.CustomerId);

            if (exists)
            {
                selectedCustomer.ContactName = c.ContactName;
                selectedCustomer.CompanyName = c.CompanyName;
                selectedCustomer.City = c.City;
                _db.SaveChanges();
            }
            return false;
           
        }


        public List<Customer> ReadAll()
        {
            return _db.Customers.ToList();
        }

        public void Remove(Customer c)
        {
            _db.Customers.Remove(c);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
