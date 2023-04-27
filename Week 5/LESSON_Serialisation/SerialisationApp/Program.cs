namespace SerialisationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matt = new Trainee() { FirstName = "Matthew", LastName = "Handley", SpartaNo = 7 };

            ISerialiser serialiser;

            string fp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +  "/Sparta Global" ;

            // serialiser.SerialiseObject<Trainee>(fp + "/vlad" , vlad);

            serialiser.SerialiseObject<Trainee>(fp + "matt.json", matt);
           // var trainee = serialiser.DeserialiseObject<Trainee>(fp + "/vlad.xml");

            
        }
    }
}