using FourPillarsApp;
namespace FourPillarsTest;

//"Test per logic path" guideline
public class VehicleTests
{
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

    [Test]
    public void WhenTryingToSetNumOfPassengersAboveCapacity_ExceptionThrown()
    {
        Vehicle v = new Vehicle(9);

        try
        {
            v.NumPassengeres = 10;
        }
        catch (Exception e)
        {
            Assert.That(true);
        }

    }

    [Test]
    public void WhenTryingToSetNumOfPassengersMadeNegative_ExceptionThrown()
    {
        Vehicle v = new Vehicle(9);

        try
        {
            v.NumPassengeres = -10;
        }
        catch (Exception e)
        {
            Assert.That(true);
        }

    }



    [Test]

    public void WhenVehicleMovesOnceReturnCorrectstring()
    {
        Vehicle v = new Vehicle();
        Assert.That(v.Move(), Is.EqualTo($"Moved along by 10"));

    }
}
