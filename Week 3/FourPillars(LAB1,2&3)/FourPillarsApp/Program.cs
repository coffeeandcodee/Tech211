namespace FourPillarsApp;

public class Program
{
    static void Main(string[] args)
    {
        #region Lecture Demos
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

        //var car = new Vehicle(24, 100);

        //Airplane a = new Airplane(200, 100, "JetsRUs");

        //Console.WriteLine(a);
        //Console.WriteLine(a.ToString());

        //var myDog = new Dog();
        //var myCat = new Cat();
        //var myBird = new Bird();

        //Console.WriteLine(myDog.Speak());
        //Console.WriteLine(myDog.Speak());
        //Console.WriteLine(myDog.Speak());

        //Console.WriteLine(("\nPolymorphism demo: \n"));

        //List<Animal> animals = new List<Animal> { myDog, myCat, myBird };

        //foreach (var animal in animals)
        //{
        //    Console.WriteLine(animal.Speak());
        //}
        //Console.WriteLine();

        //You can initialise abstract classes
        //and specify child later

        //Animal? myAnimal;

        //string input = Console.ReadLine();

        //switch (input.ToLower())
        //{
        //    case "dog":
        //        myAnimal = new Dog();
        //        break;
        //    case "cat":
        //        myAnimal = new Cat();
        //        break;
        //    case "bird":
        //        myAnimal = new Dog();
        //        break;
        //    default:
        //        Console.WriteLine("Not an animal :(");
        //        myAnimal = null;
        //        break;


        //}

        //if(myAnimal is not null) Console.WriteLine((myAnimal.Speak()));

        //Console.WriteLine();
        //List<Object> gameObjects = new List<Object>()
        //{   
        //    //capacity of 15
        //    new Airplane(15),
        //    new Dog(),
        //    new Cat(),
        //    new Park(),
        //    new Person("Jacob", "Banyard"),
        //    new Hunter("Majid", "Laklouk", "Nikon"),
        //    new Vehicle()
        //};

        //foreach (var obj in gameObjects)
        //{
        //    SpartaWrite(obj);

        //    //Casting obj as animal type
        //    if (obj is Animal)
        //    {
        //        Animal a = (Animal)obj;
        //        SpartaWrite(a.Speak);
        //    }


        //}
        //Console.WriteLine();


        //Interfaces can be treated as types
        //List<IMoveable> moveables = new List<IMoveable>
        //{
        //    new Person("Per", "Sons")
        //};

        #endregion

        #region LAB3 demos


        var laser1 = new LaserGun("brand of water1");
        var water1 = new WaterPistol("brand of water1");
        var laser2 = new LaserGun("brand of laser2");
        var water2 = new WaterPistol("brand of water2");

        var cam1 = new Camera("Cannon");
        var cam2 = new Camera("Kodak BLACk");

        var hunter1 = new Hunter("Ult", "Defa", cam1);
        var hunter2 = new Hunter("Ulto", "Defato", cam2);

        var shooters = new List<IShootable> { laser1, water1, laser2, water2, hunter1, hunter2, cam1, cam2 };

        foreach(IShootable shooter in shooters)
        {
            Console.WriteLine(shooter.Shoot());

        }


        #endregion

    }


    public static void SpartaWrite(Object obj)
    {
        Console.WriteLine($"Sparta says: {obj}");
    }


}