using NorthwindData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

// CustomerManager Executes CRUD operations.
// Interacts with an ICustomerService object (should be renamed to just IService)
namespace NorthwindBusiness;

public class CustomerManager
{
    public Customer SelectedCustomer { get; set; }

    private ICustomerService _service;

    public CustomerManager()
    {
        _service = new CustomerService();
    }

    public CustomerManager(ICustomerService service)
    {

        _service = service;
    }

    public void SetSelectedCustomer(object selectedItem)
    {

        SelectedCustomer = (Customer)selectedItem;
    }

    public List<Customer> RetrieveAll()
    {
        using (var db = new NorthwindContext())
        {
            return db.Customers.ToList();
        }
    }

    public void Create(string customerId, string contactName, string companyName, string city = null)
    {

        var newCust = new Customer() { CustomerId = customerId, ContactName = contactName, CompanyName = companyName, City = city };
        _service.Create(newCust);
    }

    public bool Update(string customerId, string contactName = null, string city = null, string postcode = null, string country = null)
    {
        var customer = new Customer()
        {
            CustomerId = customerId,
            ContactName = contactName,
            Country = country,
            PostalCode = postcode
        };

        SelectedCustomer = customer;
        return _service.Update(customer);
    }






    public bool Delete(string customerId)

    {
        try

        {
            var customer = _service.Read(customerId);
            _service.Remove(customer);
            SelectedCustomer = null;

        }

        catch (ArgumentException e)

        {
            Debug.WriteLine($"Customer {customerId} not found");
            return false;
        }
        return true;

    }



}
