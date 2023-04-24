using System.Linq;

namespace MicrosoftLINQWalkthrough;

//Walkthrough and notes from documentation
public class Program
{
    static void Main(string[] args)
    {

        //Query is of type IEnumerable<class>
        IEnumerable<Student> studentQuery =
            from s in students
            where s.Scores[0] > 90 && s.Scores[3] < 80
            orderby s.First ascending
            select s;

        //Note that the query's RANGE VARIABLE, student, serves as a reference
        //to each student in the source. student provides member access for each object.
        
        foreach(Student student in studentQuery)
        {
            //Console.WriteLine($"{student.Last}, {student.First}, {student.Scores[0]}");
        }


        //Console.WriteLine("==== GROUPING ====");

        //var keyword very handy here
        IEnumerable<IGrouping<char, Student>> studentQueryGroup =
            from student in students
            group student by student.Last[0] into studentGroup
            orderby studentGroup.Key descending
            select studentGroup;

        
        foreach(IGrouping<char, Student> group in studentQueryGroup)
        {
           //Console.WriteLine();
            //Console.WriteLine($":::KEY {group.Key}:::");
            foreach(Student student in group)
            {
                //Console.WriteLine($"{student.Last}, {student.First}");
            }
        }
        

        //Using "let" keyword


        var studentQueryLet =
            from student in students
            let totalScore = ScoreSum(student.Scores)
            select $"{student.Last} {student.First}: {totalScore}";

        //data type of elements in query whilst iteration depends on 
        //data type of the data selected. In this case, string, as string  
        //is selected in the query above
       foreach(string s in studentQueryLet)
        {
            //Console.WriteLine(s);
        }


        //method syntax in query expression

        var AverageScoreQuery =
             from s in students
             let totalScore = ScoreSum(s.Scores)
             select totalScore;
        double averageScore = AverageScoreQuery.Average();

        Console.WriteLine("Average Score: ");
        Console.WriteLine(averageScore);
        Console.WriteLine();
        var garciaQuery =
            from student in students
            where student.Last == "Garcia"
            select student.First;

       // Console.WriteLine("Grcias in the class:");
        foreach(string s in garciaQuery)
        {
            //Console.Write($"{s} ");
        }


        //USING ANONYMOUS TYPES
        Console.WriteLine();
        Console.WriteLine("====ANONYMOUS TYPES====");
        Console.WriteLine();

        var anonymousQuery =
            from student in students
            let totalScore = ScoreSum(student.Scores)
            where totalScore > averageScore
            //Anonymous type 
            select new { name = student.First, id = student.ID, score = totalScore };


        foreach(var item in anonymousQuery)
        {
            //Console.WriteLine($"{item.name} {item.score}");
        }

        //METHOD SYNTAX. Bewlow queries are identical
        int[] numbers = { 5, 10, 8, 3, 6, 12 };
        var numQuery1 =
            from n in numbers
            where n % 2 == 0
            orderby n
            select n;

        var numQuery2 = numbers
            .Where(n => n % 2 == 0)
            .OrderBy(n => n); // Ascending order by default, like query syntax above

        //If you type list. and examine the pop ups you will see query operations
        List<string> list = new List<string>();
        

        //Standard query operators are implemented as a kind of method called 
        //extension methods. Extension methods "extend" an existing type.
        //Standard query operators extend IEnumerable<T> hence numbers.Where(...)


        Console.WriteLine("===NUMBER QUERIRES===");

        foreach (int i in numQuery2)
        {
            Console.Write(i + " ");
        }
           

    }

    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;
    }

    // Create a data source by using a collection initializer.
    static List<Student> students = new List<Student>
{
    new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
    new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
    new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
    new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
    new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
    new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
    new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
    new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
    new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
    new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
    new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
    new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}},
    new Student {First="Mark", Last="Zuckerberg", ID=124, Scores= new List<int> {-135, 135, 65, 353 } }
    };

    public static int ScoreSum(List<int> scores)
    {
        int sum = 0;

        foreach(int i in scores)
        {
            sum += i;
        }
            
        return sum;
    }

}