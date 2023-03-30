using System.Linq.Expressions;

namespace ExceptionsApp;

public class Program
{
    static void Main()
    {
        //Handling exceptions
        try
        {
            var text = File.ReadAllText("C://Users//Ahmed//OneDrive//Documents//Sparta Global//Tech211//Week 2//TyesOfErrors.txt");
            Console.WriteLine(text);
        } 
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File not found");
            Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("File not found");
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("There was an error :/");
            Console.WriteLine(e.Message);

        }
        finally //Seemingly redundant? 
        {
            Console.WriteLine("Will always run");
        }
       
    }
}
