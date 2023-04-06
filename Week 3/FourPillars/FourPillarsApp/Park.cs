namespace FourPillarsApp;

public class Park
{
    public int Swings { get; set; }
    public int Roundabouts { get; set; }
    public int Trees { get; set; }
    public string Name { get; set; }


    public Person ParkManager { get; set; } = new Person("Defa", "Ult");



    public List<Person> people { get; set; } = new List<Person> { };
}
