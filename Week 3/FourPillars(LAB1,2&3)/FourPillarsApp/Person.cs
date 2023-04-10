namespace FourPillarsApp;

public class Person : IMoveable
{   //Fields are members of the class
    //Fields have a default modifier of private


    private string _firstName = "";
    private string _lastName = "";

    //Properties are public and use PascalCase

    //properties are efficient ways of creating getters and setters
    //for class data, as opposed to getters and setters in Java. Backing field made in the background, although 
    //can be made manually. Below is an example.

    private int _age;
    //Additional logic outside of simply getting and setting can be added.
    //Long example below
    public int Age
    {
        get
        {
            return _age;

        }
        set
        {
            if (value < 0)
            {
                throw new InvalidDataException();
            }
            else
                _age = value;
        }
    }

    //backing field made secretely in background
    public double Height { get; set; }

    //Default constructor
    public Person() { }

    public Person(string fName, string lName)
    {
        _firstName = fName;
        _lastName = lName;
    }

    //"this" keyword absords constructor with matching arguments given.
    public Person(string fName, string lName, int age)
        : this(fName, lName)
    {
        Age = age;
    }

    public string GetFullName()
    {
        return $"{_firstName} {_lastName}";
    }

    public string GetFullName(string title)
    {
        return $"{title} {GetFullName()}";
    }

    public override string ToString()
    {
        return "";
    }

    //Override keyword cant be used when inheriting from interfacesa
    public string Move()
    {
        return "Walking along";
    }

    public string Move(int times)
    {
        throw new NotImplementedException();
    }
}