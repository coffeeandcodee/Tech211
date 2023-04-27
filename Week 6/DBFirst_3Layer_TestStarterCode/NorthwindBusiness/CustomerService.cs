using NorthwindData;
using System;
using System.Collections.Generic;
using System.Linq;

//CustomerService interacts with databas

namespace NorthwindBusiness;

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

    public Customer? Read(string customerId)
    {
        return _db.Customers.Find(customerId);


    }
    #region Update (redundant? )
    public bool Update(Customer c)
    {
        var customerToUpdate = Read(c.CustomerId);
        if (customerToUpdate == null)
        {
            return false;
        }
        customerToUpdate.CustomerId = c.CustomerId;
        customerToUpdate.ContactName = c.ContactName;
        customerToUpdate.Country = c.Country;

        return true;

        #region Earlier method
        /* My earlier method
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
        */
        #endregion 
    }
    #endregion


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
