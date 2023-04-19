using System.Data.SqlClient;
using System.Data;

namespace AcademySQLClient;
public class Program
{
    static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;Encrypt=False;
        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
        MultiSubnetFailover=False";

    static void Main(string[] args)
    {
        AddTrainee(6, "Ferg", 29);


    }

    //Create method
    public static void AddTrainee(int id, string firstName, int age)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();

            //Creation
            var newTrainee = new Trainee(id, firstName, age);
            var createQuery = $"INSERT INTO TRAINEES VALUES({newTrainee.AddToDatabase()})";
            using (var createCommand = new SqlCommand(createQuery, connection))
            {
                createCommand.ExecuteNonQuery();
            }

        }

    }


    //Read method
    //Read a certain amount of entries from top/bottom

    //Update method


    //Delete method
    

}