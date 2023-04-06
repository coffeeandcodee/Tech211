using FourPillarsApp;


namespace FourPillarsTest;
//test anything public
//and test anything with logic
public class Tests
{




    //--------------
    
   
    [Test]
    public void TwoArgsConstructor_CreatesSpecifiedName()
    {
        Person testPerson = new Person("Test", "Testerson");
        Assert.That(testPerson.GetFullName(), Is.EqualTo("Test Testerson"));

    }

    [Test]
    public void ThreeArgsConstructor_CreatesSpecifiedName()
    {
        Person testPerson = new Person("Test", "Testerson", 30);
        Assert.That(testPerson.GetFullName(), Is.EqualTo("Test Testerson"));
        Assert.That(testPerson.Age, Is.EqualTo(30));
    }
    [Test]
    public void GetFullNameWithTitle_ReturnsCorrectTitle()
    {
  
        Person testPerson = new Person("Testie", "Testerson");
        string expectedResult = "Mr. Testie Testerson";
        Assert.That(testPerson.GetFullName("Mr."), Is.EqualTo(expectedResult));
    }

    [Test]
    public void InvalidSetAge_ThrowsException()
    {
        Person testPerson = new Person("Test", "Testerson", 30);
        try
        {
            testPerson.Age = -1;
        }
        catch(Exception e)
        {
            Assert.That(false); //this passes?
        }
        
        

    }

    [Test]
    public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
    {
        Vehicle v = new Vehicle();
        var result = v.Move(2);
        Assert.That(20, Is.EqualTo(v.Position));
        Assert.That(result, Is.EqualTo("Moving along 2 times"));
    }

    [Test]
    public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
    {
        Vehicle v = new Vehicle(5, 40);
        var result = v.Move();
        Assert.That(v.Position, Is.EqualTo(40));
    }






}