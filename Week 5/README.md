
## Wednesday 19/04 

Lesson on Continuation Integration and continued deployment (optional Week 4 Content) and then moved on to using SQL via C#, and CRUD(Create, Read, Update, Delete)
```c#
using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;
        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
        MultiSubnetFailover=False"))
        {
            connection.Open();

            Console.WriteLine(connection.State);

            //Making query string
            var query = "SELECT ContactName as 'Name' FROM CUSTOMERS";

            //SqlCommand object created
            var command = new SqlCommand(query, connection);

            var sqlReader = command.ExecuteReader();

            //This returns a single row
            sqlReader.Read();
            Console.WriteLine(sqlReader["Name"].ToString());


        }
The above code snippet makes a connection to the Northwind database and reads an entry, displaying it on the console.

```

## Thursday 20/04
Entity Framework lesson. Much easier than using SQLClient.

LINQ (language integrated query)is the name for a set of technologies based on the integration of query capabilities directly into the C# language. LINQ queries have a special syntax.

```c#
IEnumerable<ExampleType> myQuery = 
    from ExampleObject in ExampleList 
    where ExampleObject.Property == "Value"
    select ExampleObject
```
Where "ExampleList" is a list of type "ExampleType"
Above query selects entries in this list with "Property" value of "Value".

Below is an example of a grouping query. "IGrouping" interface nested in "IEnumerable" interface (?)

```c#
IEnumerable<IGrouping<char, Student>> studentQuery 2 =
    from student in students        // note how "in" always refers to a define list 
    group student by student.Last[0];
    
```
Above groups students using first letter of their last name as a key.


