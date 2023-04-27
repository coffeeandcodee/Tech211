
## Wednesday 19/04 

Lesson on Continuation Integration and continued deployment (optional Week 4 Content) and then moved on to using SQL via C#, and CRUD(Create, Read, Update, Delete)
Databases can be queried and worked with via SQLClient or Entity Framework. SQLClient uses raw strings, and is far more error prone and inconvenient to work with.
The below is a snippet of querying data via SQL Client.
The above code snippet makes a connection to the Northwind database and reads an entry, displaying it on the console.
```c#
//connection is the connection string. Found in the properties of the database (rightclick on database ----> properties).
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


```

## Thursday 20/04
Entity Framework lesson. EF is an ORM (Object relational mapper)The entity framework produces classes that represent tables and a class that represents the database. 
Building a model from database is scaffolding. Building a database from a model is migration.
Much easier than using SQLClient.
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

Some query operations can only be expressed using method syntax. Below is an example from the walkthrough. Following code calculates total score for each student in source sequence, then calls Average() on the results of the query to calculate the average score of the class

```c#
var AverageScoreQuery =
    from student in students
    let totalScore = ScoreSum(student.Scores)   //ScoreSum defined elsewhere
    select totalScore

double average Score = AverageScoreQuery


```
## Friday 21/04
Lambda expressions
Higher order functions take other functions as parameters.


Method syntax example

```c#
   var query1 =
             from c in db.Customers
            where c.City == "London"
            orderby c.ContactName
            select c;

            var queryMethodSyntax = db.Customers
                .Where( c => c.City == "London").OrderBy(c => c.ContactName);   //.Select(c => c) is implied

```

## Monday 24/04

Differentiating between model-first and database-first processes. 
The model-first, where models (classes, objects, etc...) are then converted into databases is known as **migration**. The contrary is **scaffolding**, which has has been what we have been doing thus far.

It is necessary sometimes to manually update migration files.

Initial migration command for PM Console

```
Add-Migration InitialMigration
```

For updating
```
Update-Database
```
A synchronous program executes line by line. Aynchronous programming is where this isn't the case. You can call a method and have its return value used later, and in the meantime have other processes executed

Asynchronous programming is where a program can start a process then start other processe before the earlier proccesses finish.
Asynchronous methods use "async" in the signature. Asynchronous methods should include "await" keyword.

XML: (To DO)

JSON Object example

```JSON
    "employeeId": 2983,
    

```