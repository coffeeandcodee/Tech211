using FourPillarsApp;
namespace FourPillarsTest;
public class Tests
{
    //test anything public
    //and test anything with logic
    //"Test per path" guideline
    
    public Person p;
    [SetUp]
    public void SetUp()
    {
        p = new Person("Test", "Testerson");

    }

    [Test]
    public void TwoArgsConstructor_CreatesSpecifiedName()
    {

        Assert.That(p.GetFullName(), Is.EqualTo("Test Testerson"));

    }

    [Test]
    public void ThreeArgsConstructor_CreatesSpecifiedNameAndAge()
    {
        Person p2 = new Person("Test", "Testerson", 30);
       
        Assert.That(p2.GetFullName(), Is.EqualTo("Test Testerson"));
        Assert.That(p2.Age, Is.EqualTo(30));
    }
    [Test]
    public void GetFullNameWithTitle_ReturnsCorrectTitle()
    {

        string expectedResult = "Mr. Test Testerson";
        Assert.That(p.GetFullName("Mr."), Is.EqualTo(expectedResult));
    }

    [Test]
    public void NegativeSetAge_ThrowsException()
    {
        try
        {
            p.Age = -1;
        }
        catch (Exception e)
        {
            Assert.That(true);
        }


    }
    [Test]
    public void AgeGetAndSet()
    {
        p.Age = 30;
        Assert.That(p.Age, Is.EqualTo(30));
        var age = p.Age;

    }
    [Test]

    public void AgeCanBeGet()
    {
       

    }

    [Test]
    public void AgeCanBeSet()
    {

    }
}