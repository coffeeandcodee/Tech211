using NorthwindData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBusiness;

public class InMemoryService : ICustomerService
{
    public List<Customer> db { get; set; } = new List<Customer>();
    public void Create(Customer c)
    {
        db.Add(c);
    }

    public Customer Read(string customerId)
    {
        return db.Find(c => c.CustomerId == customerId);
    }

    public List<Customer> ReadAll()
    {
        return db;
    }

    public void Remove(Customer c)
    {
        db.Remove(c);
    }

    public bool Update(Customer c)
    {
        bool exists = db.Any(customer => customer.CustomerId == c.CustomerId);
        var selectedCustomer = db.Find(customer => c.CustomerId == c.CustomerId);

        if (exists)
        {
            selectedCustomer.ContactName = c.ContactName;
            selectedCustomer.CompanyName = c.CompanyName;
            selectedCustomer.City = c.City;
            return true;
        }
        else
        {
            return false;
        }    

    }

    public void SaveChanges()
    {

    }
}
