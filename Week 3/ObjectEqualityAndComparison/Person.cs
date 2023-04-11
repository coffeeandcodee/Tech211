using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace ObjectEqualityAndComparison;

public class Person : IEquatable<Person?>, IComparable<Person>
{
    private string _firstName = "";
    private string _lastName = "";

    public int Age { get; set; }

    public Person(string firstName, string lastName, int age = 0)
    {
        Age = age;
        _firstName = firstName;
        _lastName = lastName;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Person);
    }

    public bool Equals(Person? other)
    {
        return other is not null &&
               _firstName == other._firstName &&
               _lastName == other._lastName &&
               Age == other.Age;
    }

    public override int GetHashCode()
    {
        //A HashCode is a function that returns...
        return HashCode.Combine(_firstName, _lastName, Age);
    }

    public int CompareTo(Person? other)
    {
        
        if (other is null) return 1;
        if (other.Age == Age)
        {
            if (other._lastName == _lastName)
            {
                if (other._firstName == _firstName) return 0;
                else return _firstName.CompareTo(other._firstName);
            }
            else return _lastName.CompareTo(other._lastName);
        }
        else return -1 * Age.CompareTo(other.Age);

    }

    public string GetFullName()
    {
        return $"{_firstName} {_lastName}";
    }

    public static bool operator == (Person left, Person right)
    {
        return EqualityComparer<Person>.Default.Equals(left, right);
    }

    public static bool operator != (Person left, Person right)
    {
        return !(left == right);
    }





}


