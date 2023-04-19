namespace AcademySQLClient;

public class Trainee
{
    public  int TraineeID { get; set; }
    public string? FirstName { get; set; }
    public int Age { get; set; }

    public Trainee(int traineeID, string firstName, int age)
    {
        this.TraineeID = traineeID;
        this.FirstName = firstName;
        this.Age = age;
    }

    public string AddToDatabase()
    {
        return $"{TraineeID}, '{FirstName}', {Age}";
    }

}
