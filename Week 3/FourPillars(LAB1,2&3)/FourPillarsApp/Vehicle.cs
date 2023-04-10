namespace FourPillarsApp;

public class Vehicle : IMoveable
{
    private int _capacity;
    private int _numPassengers;

    public int Position { get; private set; }
    public int NumPassengeres
    {
        get
        {
            return _numPassengers;
        }
        set
        {
            if (value < 0 || value > _capacity)
            {
                //am i doing this right???
                throw new Exception();
            }
            else
            {
                _numPassengers = value;
            }
        }
    }


    private int _age;
    public int Speed { get; init; }


    public Vehicle() { this.Speed = 10; }

    public Vehicle(int capacity, int speed = 10)
    {
        _capacity = capacity;
        Speed = speed;

    }

    public virtual string Move()
    {
        Position += Speed;
        return $"Moved along by {Speed}";
    }
    public virtual string Move(int times)
    {
        Position += times * Speed;

        //Recall the method above 
        return $"Moving along {times} times";
    }

    //I made a mistake of putting "virtual" instead of "override" which made
    //Console.WriteLine(a)
    //return App.ClassName at first
    public override string ToString()
    {
        //base.ToString() would access Object class overload
        return $"capacity: {_capacity} passengers: {NumPassengeres} speed: {Speed} position: {Position}";
    }

}
