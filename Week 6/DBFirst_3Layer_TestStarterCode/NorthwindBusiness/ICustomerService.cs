using NorthwindData;
using System.Collections.Generic;

namespace NorthwindBusiness;

public interface ICustomerService
{
    public List<Customer> ReadAll();

    public Customer Read(string customerId);

    public void Create(Customer c);

    public bool Update(Customer C);

    //We don't need update nor delete
    public void Remove(Customer c);

    public void SaveChanges();



}
