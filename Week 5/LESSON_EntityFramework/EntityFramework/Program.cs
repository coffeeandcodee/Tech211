using Microsoft.EntityFrameworkCore;
namespace EntityFramework;

public class Program
{
    public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    static void Main()
    {
        //making db object. involves connecting
        //However, DOESN'T CLOSE connection
        //db is object of type NorthwindContext() (or the database name)
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
            Console.WriteLine(selectedCustomer.City);



            //delete
            var customerToDelete = db.Customers.Find("SPART");
            db.Customers.Remove(customerToDelete);
            */
            

            

            #endregion


            #region EntityFramework lesson 2: Using LINQ
            

            //basic example
            //SYNTAX
            //from n in db.List         
            //SELECT n              
            
            //n is the RANGE VARIABLE
           

            List<int> myList = new() { 1, 3, 6, 8 };


            //This is a query, NOT the result
            //A query is an IEnumerable
            var listQuery =
                from number in myList
                where number > 4
                select number;
           //This is DEFERRED EXECUTION

            //QUeries executed at Enumeration.
            //YOu need to loop through to get result
            var myNewList = listQuery.ToList();

            //listQuery is a query, not list.
            //listQuery is itself an ENUMERABLE
            //it holds a query, not data
            foreach(var num in listQuery)
            {
                Console.WriteLine(num);
            }

           
                IEnumerable<Customer> londonBerlinCustomersQuery =
                    from customer in db.Customers
                    where customer.City == "London" || customer.City == "Berlin"
                    select customer;
                    // could also have
                    //select customer.CompanyName
                    //to select only that string 


            var londonCustomers = londonBerlinCustomersQuery.ToList();

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
                ///Console.WriteLine(item.Company + " " + item.Country);
            }

           

            
            var top10ExpensiveProductsQuery =
               from p in db.Products
               orderby p.UnitPrice descending
               select new { Name = p.ProductId, Price = p.UnitPrice };


            ///Console.WriteLine("TOP 10 query");
            foreach (var item in top10ExpensiveProductsQuery.Take(10))
            {
                ///Console.WriteLine(item.Name + " " + item.Price);
            }



            //SQL equivalent for query below.

            //SELECT supplierID, Count(productId)
            //FROM Products
            //GROUP BY SupplierID


            var productsPerSupplierQuery =
                from p in db.Products
                group p by p.SupplierId into productsOfASupplier                //Group by Range Variable (range variable being p here) property, then define variable that represents group, via "into {grouupname}"
                select new { 
                    SupplierID = productsOfASupplier.Key,
                    Products = productsOfASupplier.Count(),
                    UnitsInStock = productsOfASupplier.Sum(p => p.UnitsInStock)    //There exists a "UnitsInStock" column in the produS
                    };                                                  //Anonymous object. The key is the grouping used, in this case SupplierID                                

            //The .Key is whatever you've grouped by, in this case SupplierId
           //NOTE: IGrouping objects is not the group itself, similar to how 
           //query isn't the result itself. 
           //Anonymous object will have a SupplierID property, which is equal to the Key (Products.supplierId)
           
          foreach(var item in productsPerSupplierQuery)
            {
                ///Console.WriteLine($"Supplier ID: {item.SupplierID} No. Of Products: {item.Products} IDK: {item.UnitsInStock}");
            }
      
                
          
           
            
            
            #endregion


        }

        //outside using block
        #region Lambda Syntax
        

        //lamba expressions have no method signature
        //input object => return expression result
        //x =>  x * x 


        //Possible syntax
        // Func <int, int> lambdaSquareMe = x => x * x;

        var nums = new List<int>() { 3, 6, 4, 2, 51 };

        var countOfNums = nums.Count();

        //Count overload below 
        //Lambda expressions are used as arguments for methods
        //lamba expression used when repitition is redundant 
        //defining function in Count would be needless

        var countOfEvenNums = nums.Count(n => n % 2 == 0);
        var countOfNumsAbove5 = MyCount(nums, n => n > 5);

        //multiple arguments

        var total = DoMaths(5, 6, (x, y) => x + y);



        using (var db = new NorthwindContext()) {

            //query1 and queryMethodSyntax are Equivalent
            var query1 =
             from c in db.Customers
            where c.City == "London"
            orderby c.ContactName
            select c;

            var queryMethodSyntax = db.Customers
                .Where( c => c.City == "London").OrderBy(c => c.ContactName);   //.Select(c => c) is implied


            //method Syntax equivalent of productPerSupplierQuery from LINQ lesson. 
            //NOTE paste Query equivalent above

            var productsPerSupplierQuerySyntax =
                from p in db.Products
                group p by p.SupplierId into productsOfASupplier                //Group by Range Variable (range variable being p here) property, then define variable that represents group, via "into {grouupname}"
                select new
                {
                    SupplierID = productsOfASupplier.Key,
                    Products = productsOfASupplier.Count(),
                    UnitsInStock = productsOfASupplier.Sum(p => p.UnitsInStock)    //There exists a "UnitsInStock" column in the products table
                };



            var productPerSupplierMethodSyntax = db.Products
                .GroupBy(p => p.SupplierId).Select(
                productsOfASupplier => new
                { 
                    SupplierID = productsOfASupplier.Key,  
                    SupplierName = db.Suppliers
                    .Where(s => s.SupplierId == productsOfASupplier.Key)
                    .Select(s => s.CompanyName).First(),
                    Products = productsOfASupplier.Count() 
                }
                );
                
            foreach(var result in productPerSupplierMethodSyntax)
            {
                Console.WriteLine($"Supplier ID: {result.SupplierID} - Company {result.SupplierName} - Number of Products {result.Products}");
            }


            //Order products by QuantityPerUnit Challenge query 
            var quantityPerUnitQuery =
                from p in db.Products
                orderby p.QuantityPerUnit, p.ReorderLevel descending
                select new { p.ProductName, p.QuantityPerUnit};

            var quantityPerUnitQueryMethodSyntax =
                db.Products.OrderBy(p => p.QuantityPerUnit)
                           .ThenByDescending(p => p.ReorderLevel);  //note method for Descending

            
            




        }


        #endregion


        //================ JOINS ==================
        #region Loading and joining in EF

        using (var db = new NorthwindContext())
        {
            var orderQuery = db.Orders.Where(o => o.Freight > 750)
                .Include(o => o.Customer).Include(o => o.OrderDetails) //Include is similar to join in SQL
                .ThenInclude(od => od.Product);
            foreach(var bigOrder in orderQuery)
            {
                Console.WriteLine(bigOrder.Customer.CompanyName);

                foreach(var orderDetail in bigOrder.OrderDetails)
                {
                    Console.WriteLine($"\t {orderDetail.ProductId} {orderDetail.Product.ProductName}");
                }

            }

            //Cannot use LINQ join with EF without using Include() ?
            //eliminating lines 250 to 262 ruins query below
            var ordersQuery2 =
                from o in db.Orders
                where o.Freight > 750
                join c in db.Customers on o.CustomerId equals c.CustomerId
                join od in db.OrderDetails on o.OrderId equals od.OrderId
                select o;

            foreach(var bigOrder in ordersQuery2)
            {
                Console.WriteLine(bigOrder.Customer.CompanyName);

                foreach(var orderDetail in bigOrder.OrderDetails)
                {
                    Console.WriteLine($"\t {orderDetail.ProductId} {orderDetail.Product.ProductName}");
                }
            }

            // .Join() can be used to create relationships that don't exist on db side

            var customersAndSuppliersInTheSameCity = db.Customers
                .Join(db.Suppliers, c => c.City, s => s.City, (c, s) => new
                {
                    Customer = c.ContactName,
                    CustomerCompany = c.CompanyName,
                    Supplier = s.CompanyName,
                    SupplierContact = s.ContactName
                });

            foreach(var result in customersAndSuppliersInTheSameCity)
            {
                Console.WriteLine($"Customer {result.Customer} from {result.CustomerCompany} is near {result.Supplier}");
            }


            //SQL task 1.4
            var productsPerCategoryQ = db.Products.Include(p => p.Category)
                .GroupBy(p => p.Category.CategoryName)
                .OrderByDescending(ppc => ppc.Count()).Select(ppc => new
            {
                CategoryName = ppc.Key, 
                ProductCount = ppc.Count()    

            });
        }





        #endregion



    }

    private static object DoMaths(int n1, int n2, Func<int, int, int> expression)
    {
        return expression(n1, n2);
    }


    public static int SquareMe(int x)
    {
        return x * x;
    }

    //Func<int, bool> is a delegate. Takes in int, returns bool

    public static int MyCount(List<int> list, Func<int, bool> condition)
    {
        int count = 0;

        foreach (var n in list)
        {
            if (condition(n)) count++;
        }

        return count;

    }



}