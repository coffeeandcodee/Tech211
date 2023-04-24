using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Diagnostics.Metrics;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace QuerySyntaxAndMethodSyntaxSQLTask;

public class Program
{
    static void Main(string[] args)
    {

        using (var db = new NorthwindContext())
        {
            #region 1.1
            //1.1
            //query syntax.
            var parisOrLondonQuery =
                from c in db.Customers
                where c.City == "London" || c.City == "London"
                select new
                {
                    CustomerID = c.CustomerId,
                    CompanyName = c.CompanyName,
                    Address = $"{c.City}, {c.PostalCode}, {c.Address}, {c.Country}"
                };

            var parisOrLondonMethod = db.Customers.Where(c => c.City == "London" || c.City == "Paris").Select(c => new
            {
                CustomerID = c.CustomerId,
                CompanyName = c.CompanyName,
                Address = $"{c.City}, {c.PostalCode}, {c.Country}"
            });
            
            foreach(var c in parisOrLondonMethod)
            {
                ///Console.WriteLine($"ID: {c.CustomerID} | Company Name: {c.CompanyName} | Address: {c.Address}");
            }

            #endregion

            #region 1.2 & 1.3

            var bottleQuery =
                from p in db.Products
                  where p.QuantityPerUnit.Contains("bottle")
                select p;

            var bottleMethod = db.Products.Where(p => p.QuantityPerUnit.ToLower().Contains("bottle"));

            foreach(var c in bottleMethod)
            {
                ///Console.WriteLine($"{c.ProductName}:  {c.QuantityPerUnit}");
            }

            var bottleMethod2 = db.Products.Where(p => p.QuantityPerUnit.ToLower().Contains("bottle")).Join(db.Suppliers, p => p.SupplierId, s => s.SupplierId, (p, s) => new
            {
                ProductName = p.ProductName,
                QperU = p.QuantityPerUnit,
                SupplierName = s.CompanyName,
                SupplierCountry = s.Country

            });

            foreach (var item in bottleMethod2)
            {
                ///Console.WriteLine($"{item.ProductName} | {item.QperU} | {item.SupplierName} | {item.SupplierCountry}");

            }

            #endregion

            #region 1.4 REVISIT
            //1.4
            /*   RAW SQL 
                
                   SELECT c.CategoryName, COUNT(*) AS "Number of Products"
                    From Products p
                    JOIN Categories c ON p.CategoryID = c.CategoryID
                    GROUP BY(c.CategoryName)
                    ORDER BY COUNT(*) desc
            */

            //query syntax
            //check recording 09, around 10 minutes in
           
            // var query4 = 
             //   from c in db.Categories
               // join p in db.Products on c.CategoryId equals p.CategoryId
               

            //method syntax. Check recording


            var productsPerCategoryMethod = db.Products.Include(p => p.Category)
                .GroupBy(p => p.Category.CategoryName)
                .OrderByDescending(ppc => ppc.Count()).Select(ppc => new
                {
                    CategoryName = ppc.Key,
                    ProductCount = ppc.Count()

                });
            foreach (var item in productsPerCategoryMethod)
            {

            }

            #endregion

            #region 1.5 
            var ukQuery =
                from e in db.Employees
                where e.Country == "UK"
                select new
                {
                    TitleName = $"{e.TitleOfCourtesy} {e.FirstName} {e.LastName}",
                    City = e.City

                };


            var ukMethod = db.Employees.Where(e => e.Country == "UK").Select(e => new
            {
                TitleName = $"{e.TitleOfCourtesy} {e.FirstName} {e.LastName}",
                City = e.City
            });

            foreach (var item in ukQuery)
            {
                ///Console.WriteLine($"{ item.TitleName} City: {item.City} ");
            }

            #endregion

            #region 1.6
            //check recording 09 at ~18 minutes in





            #region 1.8

            var orderWithHighestDiscount = db.Orders.Include(o => o.OrderDetails).Select(o =>
            {

            });
            

            var orderWithHighestDiscount2 = db.Orders.Include(o => o.OrderDetails).Select(o => new

            {
                o.OrderId,
                TotalDiscount = o.OrderDetails.Sum(od => od.UnitPrice * od.Quantity * (decimal)od.Discount)

            }).OrderByDescending(owhd => owhd.TotalDiscount).First();




            #endregion




            #region 3.1

            // var reportsToQuery



            var reportsToMethod = db.Employees.Join(db.Employees, e1 => e1.ReportsTo, e2 => e2.EmployeeId, (employee, reportsTo) => new
            {
                EmployeeName = $"{employee.FirstName} {employee.LastName}",
                ReportsTo = $"{reportsTo.FirstName} {reportsTo.LastName}"
            }).OrderBy(e => e.ReportsTo);
            
            foreach (var item in reportsToMethod)
            {
                Console.WriteLine($"{item.EmployeeName} reports to {item.ReportsTo}");
            }


            #endregion  3.1

            //var suppliersWithSalesOver10000 = 


        }



    }
}