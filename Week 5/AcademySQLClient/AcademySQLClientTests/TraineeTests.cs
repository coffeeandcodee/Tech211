using AcademySQLClient;
namespace AcademySQLClientTests;

public class Tests
{
    Trainee test;
   
    [SetUp]
    public void Setup()
    {
        test = new Trainee(1, "Default", 20);
    }

    [Test]
    public void TraineeConstructorWorksAsExpected()
    {
        Assert.That(test.TraineeID, Is.EqualTo(1));
    }

    [Test]
    public void AddToDatabase_ReturnsCorrectlyFormattedString()
    {
        Assert.That(test.AddToDatabase(), Is.EqualTo("'1', 'Default', '20'"));
    }
}