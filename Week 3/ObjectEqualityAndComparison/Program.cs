namespace ObjectEqualityAndComparison;

public class Program
{
    static void Main(string[] args)
    {
        var andrew = new Person("andy", "Thomas", 9);
        var phil  = new Person("Phil", "Thomas", 2);

        Console.WriteLine("Andrew and phil are equal?" + andrew.Equals(phil));  //comparing location in memory in HEAP


        var andrewClone = andrew;
        Console.WriteLine(andrew.Equals(andrewClone)); //true

        List<int> list = new() { 5, 1, 7, 99, 33 };
        list.Sort();

        foreach(int n in list) Console.WriteLine(n);

        List<Person> people = new() { andrew, phil, andrewClone, new Person("Talal", "Hassan", 5), new Person("Danyal", "Saleh", 5000) };
        people.Sort();

        foreach(var p in people)
        {
            Console.WriteLine(p.GetFullName());
        }

    }
}