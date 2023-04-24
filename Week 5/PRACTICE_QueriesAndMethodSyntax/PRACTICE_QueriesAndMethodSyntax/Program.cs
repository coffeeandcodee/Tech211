using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PRACTICE_QueriesAndMethodSyntax;
//RESUME LAMBDA EXPRSSIONS VIDEO AT 49:30
public class Program
{
    static void Main(string[] args)
    {
        var nums = new List<int> { 5, 5 };
        

        //Multiples numbers by 2 then sums
        var result = MethodInMethod(nums, n => n * 2);

        //Multiple parameters

        var result2 = DoMaths(10, 3, (elephants, giraffes) => elephants + giraffes);        //Naming doesn't matter. I's inferred from DoMaths declaration below that the third parameter 
                                                                                            //is a method that takes in two argument

       ///Console.WriteLine(result2);
        //example with tuples
        var result3 = DoMaths2(5, 6, (x, y) => (x + y, x-y));
        ///Console.WriteLine(result3);

        using(var db = new NorthwindContext())
        {
            var query1 =            
                from c in db.Customers
                where c.City == "London"
                orderby c.ContactName
                select c;


            //Method syntax in lesson starts at 46:00
            var methodSyntax = db.Customers.Where(c => c.City == "London").OrderBy(c => c.ContactName);

            foreach(var c in query1)
            {
                ///Console.WriteLine($"city: {c.City} name: {c.ContactName} ");
            }


            //Product per supplier query from previous lesson. Found in
            //EntityFramework solution
            //SQL equivalent for query below.
            //SELECT supplierID, Count(productId)
            //FROM Products
            //GROUP BY SupplierID


            var productsPerSupplierQuery =
                from p in db.Products
                group p by p.SupplierId into productsOfASupplier                //Group by Range Variable (range variable being p here) property, then define variable that represents group, via "into {grouupname}"
                select new
                {   SupplierID = productsOfASupplier.Key,
                    SupplierName = from s in db.Suppliers where s.SupplierId == productsOfASupplier.Key select s.CompanyName.First(),  //NESTED QUERY. Exectued by .First()
                    Products = productsOfASupplier.Count(),
                    UnitsInStock = productsOfASupplier.Sum(p => p.UnitsInStock)   //There exists a "UnitsInStock" column in the produS
                };

            var ppsMethodSyntax = db.Products
                                .GroupBy(p => p.SupplierId)
                                .Select(productsOfASupplier => new
                                {
                                    SupplierID = productsOfASupplier.Key,
                                    SupplierName = db.Suppliers.Where(s => s.SupplierId == productsOfASupplier.Key).Select(s => s.CompanyName).First(), //Retrieving the name of suppliers from Suppliers table VIA ANOTHHER QUERY 
                                    //Important to note that the above is still a query until executed by .First(). Not until then
                                    //Compare to query within query in Query syntax above
                                    Products = productsOfASupplier.Count()
                                }
                           );

            foreach(var item in ppsMethodSyntax)
            {
                Console.WriteLine($"{item.SupplierID} - No. Products: {item.Products}");
            }

        }



    }


    private static int DoMaths(int n1, int n2, Func<int, int, int> expression)        //<==== Takes a metehod as third parameter. This method takes two int inputs and returns an int input
    {
        return expression(n1, n2); 

    }



    private static (int ,int) DoMaths2(int n1, int n2, Func<int, int, (int output1, int output2)> expression)      //method passed in takes two int inputs and returns a tuple 
    {

        return expression(n1, n2);
    }


   
    


    //"redefining" count method
    //Below function takes in method as second argument

    public static int MethodInMethod(List<int> list, Func<int, int> function)
    {
        int sum = 0;
        foreach (int i in list)
        {
            sum += function(i);
        }
        return sum;
    }

}