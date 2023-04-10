namespace FourPillarsApp;

public class Hunter : Person, IShootable
{

    public IShootable Shooter { get; set; }

    //Inheriting via "base" keyword

    public Hunter(string fName, string lName, IShootable camera) : base(fName, lName)
    {
        Shooter = camera;

    }

    public string Shoot()
    {   //GetFullName() is public. Available within hunter.
        return $"{GetFullName()} took photo with ";
    }


    //Would already inherits ToString() from Object superclass. Overridden with
    //Override keyword
    public override string ToString()
    {
        return $"{base.ToString()} camera: ";
    }
}
