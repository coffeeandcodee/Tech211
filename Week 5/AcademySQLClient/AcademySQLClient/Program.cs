using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace AcademySQLClient;
public class Program
{
    public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;Encrypt=False;
        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
        MultiSubnetFailover=False";

    static void Main(string[] args)
    {
        CreateTrainee(6, "Ferg", 29);

    }

    //Create method
    public static void CreateTrainee(int id, string firstName, int age)
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
    public List<Trainee> ReadTrainee(int NumberOfEntries)
    {
        //connection is an SqlConnection object
        using(var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var Trainees = new List<Trainee>();

            var query = "SELECT * FROM TRAINEES";

            //command is an SqlCommand object
            using(var command = new SqlCommand(query, connection))
            {
                var sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    int id = Int32.Parse(sqlReader["TraineeID"].ToString());
                    var trainee = new Trainee();
                    trainee.TraineeID = id;
                  
                }

                return Trainees;

            }
            
        }

    }


   

    //Update method
    public void Update()
    {

    }

    //Delete method

    public void DeleteTrainee()
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var deleteQuery = $"DELETE FROM TRAINEES WHERE FirstName = 'Crash'";

            using(var deleteCommand = new SqlCommand(deleteQuery, connection))
            {
                deleteCommand.ExecuteNonQuery();
            }


        }

    }




}