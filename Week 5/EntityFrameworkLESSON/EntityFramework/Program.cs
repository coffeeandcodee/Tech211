using System.Reflection.Emit;

namespace EntityFramework;

public class Program
{
    public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

static void Main()
    {
        //making db object. involves connecting
        //However, DOESN'T CLOSE connection
        using (var db = new NorthwindContext())
        {

            #region EntityFramework lesson 1
            /*

            Console.WriteLine(db.ContextId);
            //Read
            foreach (var customer in db.Customers)
            {
                Console.WriteLine(customer.ContactName);
            }

            //create
            var newCustomer = new Customer() { CustomerId = "SPART",
                CompanyName = "SpartaGlobal", ContactName = "Peter Bellaby" };
            //Adding new customer to memory list
            db.Customers.Add(newCustomer);

            //Does a lot of background work including generating sql needed
            //to propagate changes. It then executes SQL
            db.SaveChanges();



            //Update

            //finding
            var selectedCustomer = db.Customers.Find("SPART");

            //updating
            selectedCustomer.City = "Birmingham";
            db.SaveChanges();

            selectedCustomer = db.Customers.Find("SPART");
            Console.WriteLine((selectedCustomer.City);



            //delete
            var customerToDelete = db.Customers.Find("SPART");
            db.Customers.Remove(customerToDelete);

            

            */

            #endregion


            #region EntityFramework lesson 2: LINQ

            List<int> myList = new() { 1, 3, 6, 8 };


            //This is a query, NOT the result
            //A query is an IEnumerable
            var listQuery =
                from number in myList
                where number > 4
                select number;
           //This is DEFERRED EXECUTION

            //QUeries exited at Enumeration.
            //YOu need to loop through to get result
            var myNewList = listQuery.ToList();

            //listQuery is a query, not list.
            //listQUery is itself an ENUMERABLE
            //it holds a query, not data
            foreach(var num in listQuery)
            {
                Console.WriteLine(num);
            }

           
                IEnumerable<Customer> londonCustomersQuery =
                    from customer in db.Customers
                    where customer.City == "London" 
                    select customer;
                    // could also have
                    //select customer.CompanyName
                    //to select only that string 


            var londonCustomers = londonCustomersQuery.ToList();

            foreach(var customer in londonCustomers)
            {
                Console.WriteLine($"{customer.ContactName} in {customer.City}");
            }

            Console.WriteLine();
            Console.WriteLine("Anonymous type query");
            Console.WriteLine();

            var londonBerlinCompanyAndCountryQuery =
               //In SQL
               //SELECT CompanyName, Country FROM Customers
               //WHERE City IN ('London', 'Berlin')

               from c in db.Customers
               where c.City == "London" || c.City == "Berlin"
               select new { Company = c.CompanyName, Country = c.Country };
                //anonymous object

            foreach(var item in londonBerlinCompanyAndCountryQuery)
            {
                Console.WriteLine(item.Company + " " + item.Country);
            }

            Console.WriteLine();
            Console.WriteLine("TOP 10 query");
            Console.WriteLine();

            var top10ExpensiveProductsQuery =
               from p in db.Products
               orderby p.UnitPrice descending
               select new { Name = p.ProductId, Price = p.UnitPrice };



            foreach(var item in top10ExpensiveProductsQuery.Take(10))
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }



            var productStockPerSupplierQuery =
                from p in db.Products
                group p by p.SupplierId into productsOfASupplier
                select new { SupplierId = productsOfASupplier.Key, Products = productsOfASupplier.Count() };
            //SQL equivalent
            //SELECT supplierID, Count(productId)
            //FROM Products
            //GROUP BY productId

            foreach(var item in productStockPerSupplierQuery) Console.WriteLine(item.SupplierId + " " + item.Products);


            #endregion

        }






    }
}