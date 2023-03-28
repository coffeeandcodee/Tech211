using UnitTestLessonApp;

namespace UnitTestLessonTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    // FOUR tests necessary 
    //One for each time ranges. 
    //EVENING has two 
    [Test]

    //0 is evening
    //2 is evening
    //4 is evening

    //5 is morning
    //9 is morning
    //11 is morning

    //12 is afternoon // RECHOCK THIS CASE. should it be 13?
    //15 is afternoon
    //18 is afternoon

    //19 is evening
    //21 is evening
    //24 is evening (two midnights, which is OK)

    //Arrange
    //These are parameterized tests
    [TestCase(12, "Good afternoon!")]
    [TestCase(15, "Good afternoon!")]
    [TestCase(18, "Good afternoon!")]
    public void GivenTimeOfDay_GetMessage_ReturnsGoodExpectedMessage(int timeOfDay, string 
        expectedResult)
    {
        string actualResult = Program.GetMessage(timeOfDay);
           
        Assert.That(expectedResult, Is.EqualTo(actualResult));

    }

    public void Given0_GetMessage_ReturnsGoodEvening()
    {

        int timeOfDay = 0;
        string expectedResult = "Good evening!";

        string actualResult = Program.GetMessage(timeOfDay);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    public void Given2_GetMessage_ReturnsGoodEvening()
    {

        int timeOfDay = 2;
        string expectedResult = "Good evening!";

        string actualResult = Program.GetMessage(timeOfDay);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    public void Given4_GetMessage_ReturnsGoodEvening()
    {

        int timeOfDay = 4;
        string expectedResult = "Good evening!";

        string actualResult = Program.GetMessage(timeOfDay);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }
    public void Given5_GetMessage_ReturnsGoodMorning()
    {

        int timeOfDay = 5;
        string expectedResult = "Good morning!";

        string actualResult = Program.GetMessage(timeOfDay);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }
    public void Given9_GetMessage_ReturnsGoodMorning()
    {

        int timeOfDay = 9;
        string expectedResult = "Good morning!";

        string actualResult = Program.GetMessage(timeOfDay);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    public void Given11_GetMessage_ReturnsGoodMorning()
    {

        int timeOfDay = 11;
        string expectedResult = "Good morning!";

        string actualResult = Program.GetMessage(timeOfDay);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

  



    public void Given12_GetMessage_ReturnsGoodAfternoon()
    {
        //Can be seen as a gherkin script
        //Arrange - Given
        int timeOfDay = 12;
        string expectedResult = "Good afternoon!";

        //Act - When
        string actualResult = Program.GetMessage(timeOfDay);

        //Assert - Then
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    public void Given15_GetMessage_ReturnsGoodAfternoon()
    {
       
        int timeOfDay = 15;
        string expectedResult = "Good afternoon!";

        string actualResult = Program.GetMessage(timeOfDay);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }
    public void Given18_GetMessage_ReturnsGoodAfternoon()
    {

        int timeOfDay = 18;
        string expectedResult = "Good afternoon!";

        string actualResult = Program.GetMessage(timeOfDay);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    public void Given21_GetMessage_ReturnsGoodEvening()
    {

        int timeOfDay = 21;
        string expectedResult = "Good evening!";

        string actualResult = Program.GetMessage(timeOfDay);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }
    public void Given24_GetMessage_ReturnsGoodEvening()
    {

        int timeOfDay = 24;
        string expectedResult = "Good evening!";

        string actualResult = Program.GetMessage(timeOfDay);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }


}