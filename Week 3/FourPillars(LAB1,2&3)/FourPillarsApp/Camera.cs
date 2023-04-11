namespace FourPillarsApp;

public class Camera : IShootable
{


    private string _brand = "";

    public Camera(string brand)
    {
        _brand = brand;
    }
    public string Shoot()
    {
        return $"SHOT picture with {_brand}";
    }

    public override string ToString()
    {
        return $"{_brand}";
    }
}
