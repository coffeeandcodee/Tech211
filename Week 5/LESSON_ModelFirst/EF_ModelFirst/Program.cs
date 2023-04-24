using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF_ModelFirst;

class Program
{
    static void Main(string[] args)
    {
        using (var db = new SouthwindContext())
        {
            //CREATING
            db.Customers.Add(new Customer()
            { 
                ContactName = "Phillip Thomas",
                City = "Ironbridge", 
                CustomerId = "PHILT", 
                PostalCode = "AB1 2CD"
            });
            db.Customers.Add(new Customer() 
            {
                ContactName = "Danyal Saleh", 
                City = "Reading", 
                CustomerId = "DANYS", 
                PostalCode = "XY1 2ZW" 
            });
            //READING

            db.SaveChanges();
        }
    }
}
