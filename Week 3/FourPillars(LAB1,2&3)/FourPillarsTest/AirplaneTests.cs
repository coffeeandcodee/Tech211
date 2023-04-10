using FourPillarsApp;

namespace AirplaneTests;

public class AirplaneTests
{
    public Airplane a;
    [SetUp]
    public void SetUp()
    {
        a = new Airplane(100, 100, "AirDanyal");

    }
    [Test]
    public void OneArgMoveMethod_ReturnsCorrectString()
    {
        
        a.Ascend(500);
        Assert.That(a.Move(3), Is.EqualTo("Moving along 3 times at an altitude of 500 metres"));

    }

    
}