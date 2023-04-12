namespace ObjectEqualityAndComparison;

public class Program
{
    static void Main(string[] args)
    {
        #region equality&comparison
        /* var andrew = new Person("andy", "Thomas", 9);
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
         }*/
        #endregion


        #region collections
        //Collections implement IEnumerable interface

        //First in first out
        Queue<int> myQ = new();
        myQ.Enqueue(1);
        myQ.Enqueue(2);
        myQ.Enqueue(3);
        
        //FIFO
        while(myQ.Count > 0) Console.WriteLine(myQ.Dequeue());

        Stack<int> myStack = new();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        //First in LAST out for stacks
        while(myStack.Count > 0) Console.WriteLine(myStack.Pop());

        List<int> challenge = new() { 5, 4, 3, 9, 0 };
        challenge.Add(8);
        challenge.Sort();
        challenge.RemoveAt(1);
        challenge.RemoveAt(1);
        challenge.Insert(2, 1);
        challenge.Reverse();
        challenge.Remove(9);


        Console.WriteLine();
        foreach (var n in challenge) { Console.Write(n); }

        //Every element in a HashSet is unique
        var numberSet = new HashSet<int>() { 1, 2, 3, 3 };

        var peopleSet = new HashSet<Person>();
        peopleSet.Add(new Person("Matt", "Handley", 0));
        peopleSet.Add(new Person("Daniel", "Manu", 0));
        peopleSet.Add(new Person("Daniel", "Manu", 0));

        //HashSets are unordered in memory. 
        //Accessing data in hashsets is much faster
        //non identical objects can possible have the same hash code.

        //If a hashcode is shared, the Equals metehod is required to differentiate.

        Console.WriteLine(numberSet.Add(3));

        //Dictionaries are collections of keys and values
        //Every key is unique

        var p1 = new Person("pal", "sal");
        var p2 = new Person("cal", "hal");
        var p3 = new Person("qual", "nal");
        var p4 = new Person("dual", "wal");

        var nickname = new Dictionary<string, Person>
        {
            {"p", p1 },
            {"c", p2 },
            {"q", p3 }
        };

        //or
        nickname.Add("Mighty", p4);
        Console.WriteLine(nickname["p"].GetFullName());

        var keys = nickname.Keys.ToList();
        var values = nickname.Values.ToList();

        string input = "The cat in the hat comes back.";
        var LetterFrequencies = new Dictionary<char, int>();
        foreach(char c in input)
        {
            if (LetterFrequencies.ContainsKey(Char.ToLower(c))) LetterFrequencies[Char.ToLower(c)]++;
            else if(c != ' ' && c != '.') LetterFrequencies[Char.ToLower(c)] =  1;

        }

        foreach(KeyValuePair<char, int> entry in LetterFrequencies)
        {
            Console.WriteLine(entry);
        }


        #endregion
    }
}