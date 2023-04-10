namespace FourPillarsApp;

public abstract class Animal
{

    private string _name;
    public string Kingdom { get; set; }
    public int Legs { get; set; }
    public DateTime Age { get; set; }



    //abstract method. Abstract keyword doubles as virtual
    public abstract string Speak();

    //Virtual must have an implementation as opposed to abstract methods.
    public virtual double Move()
    {
        return 0d;
    }

}

public class Dog : Animal
{
    public double Speed { get; set; } = 10;

    //Abstract methods HAVE TO be implemented in subclasses
    public override string Speak()
    {
        return "Bark";
    }
    //sealed means ovverride but can't be "overidden" again
    public override sealed double Move()
    {
        return Speed;
    }
}



public class Cat : Animal
{
    public override string Speak()
    {
        return "Mewo";
    }
}

public class Bird : Animal
{
    public override string Speak()
    {
        return "Cheep";
    }
}