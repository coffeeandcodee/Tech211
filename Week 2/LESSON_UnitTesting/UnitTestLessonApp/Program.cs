namespace UnitTestLessonApp;

public class Program
{
    static void Main(string[] args)
    {
        int timeOfDay = Int32.Parse(Console.ReadLine());

        Console.WriteLine(GetMessage(timeOfDay));
    }

    public static string GetMessage(int timeOfDay)
    {
        string message;
        if (timeOfDay >= 5 && timeOfDay < 12)
        {
            message = "Good morning!";
        }
        else if (timeOfDay >= 12 && timeOfDay <= 18)
        {
            message = "Good afternoon!";
        }
        else
        {
            message = "Good evening!";
        }

        return message;
    }
}