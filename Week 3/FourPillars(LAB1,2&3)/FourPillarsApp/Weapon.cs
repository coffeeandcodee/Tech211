namespace FourPillarsApp;

public abstract class Weapon : IShootable
{
    private string _brand = "";

    protected Weapon(string brand)
    {
        _brand = brand;
    }

    public abstract string Shoot();

    //Potential mistake with abstract or override keywords here
    public abstract override string ToString();


}

public class LaserGun : Weapon
{

    public LaserGun(string brand): base(brand) { }

    public override string Shoot()
    {
        return $"ZING!";
    }

    public override string ToString()
    {
        return $"Laser Gun";
    }

   
}

public class WaterPistol : Weapon
{
    public WaterPistol(string brand) : base(brand) { }
   
    public override string Shoot()
    {
        return "SPLASH!";
    }

    public override string ToString()
    {
        return $"Water Pistol";
    }
}

