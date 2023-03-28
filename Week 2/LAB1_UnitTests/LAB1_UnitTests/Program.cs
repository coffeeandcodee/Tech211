namespace LAB1_UnitTests;


public class Program
{
    static void Main()
    {

    }

    //Method amended according to bbfc guidelines 
    public static string AvailableClassifications(int ageOfViewer)
    {
       
        string result;
        if (ageOfViewer < 12)
        {
            result = "U & PG films available.";
        }
        else if (ageOfViewer < 15)
        {
            result = "U, PG, & 12 films available.";
        }
        else
        {
            result = "All films are available.";
        }
        return result;
    }
}