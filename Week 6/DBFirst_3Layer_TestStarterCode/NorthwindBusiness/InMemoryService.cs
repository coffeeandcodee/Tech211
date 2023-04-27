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

    public void SaveChanges()
    {

    }
}
