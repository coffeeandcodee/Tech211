using System.Diagnostics.Metrics;

namespace FourPillarsApp;

public class Program
{
    static void Main(string[] args)
    {
        //Objects go on the heap
        Person andrew = new Person("Andrew", "Ma");
        //can also use emit either "Person" class names
        Person andy = new("Andrew", "Ma");

        //Object properties and fields exist on
        //the the heap
        andrew.Age = 22;

        //NOT being able to do line below is ENCAPSULATION
        //andrew.firstName = "Andy";
        var talal = new Person("Talal", "Hassan", 22);
        int[] array = new int[] { 1, 2, 3 };  //Similarly

        //Initialising properties as well as fields
        Person patrick = new Person("Patrick", "Ardagh") { Age = 24, Height = 300 };
     

        //Default constructor beign ca
       // Park park = new Park() { Roundabouts = 1, Swings = 9, ParkManager = new Person("Manx", "Spanx")};

        Point3D point = new Point3D(1, 2);
        Point3D theresAlwaysABlankConstructor = new Point3D();
        Point3D empty;
        // Console.WriteLine(point.x);



        //Hunter h = new Hunter("Hunter", "Munter", "kodak");
        //Console.WriteLine(h.ToString());

        //Hunter idris = new("Idris", "Ahmed", "Cannon");


        //Console.WriteLine($"idris Equals danielle? {idris.Equals(h)}");

        //Console.WriteLine($"idris HashCode: {idris.GetHashCode()}");

        //Console.WriteLine($"idris Type: {idris.GetType()}");

        //Console.WriteLine($"idris ToString: {idris}");

        var car = new Vehicle(24, 100);

        Console.WriteLine(car.Speed);


    }
}