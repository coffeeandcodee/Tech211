namespace EntityFrameworkACADEMY;

public class Program
{
    static void Main(string[] args)
    {


     
        
        

    }

    public void CreateTrainee(int traineeId, string firstName, int age)
    {
        using (var db = new AcademyContext())
        {
            Console.WriteLine(db.ContextId.GetType());

            var newTrainee = new Trainee() { TraineeId = 10, FirstName = "John", Age = 40 };

            db.Trainees.Add(newTrainee);
            db.SaveChanges();

        }

    }
    
}