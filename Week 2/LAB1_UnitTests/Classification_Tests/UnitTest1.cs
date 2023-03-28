using LAB1_UnitTests;

//NOTE - Ages assumed to be integer values (i.e upper age bound for those who can only watch U & PG is 11)

namespace Classification_Tests
{
    public class Tests
    {
        //Test cases for 0 <= age < 12 range
      
        [TestCase(0, "U & PG films are available.")]//Test cases consist of the two bounds as input (in this case, 0 & 11) and a
        [TestCase(7, "U & PG films are available.")]//As well as an arbitrary point within range, in this case 7
        [TestCase(11,"U & PG films are available.")]

        //Test cases for 12 <= age < 15 range
        [TestCase(12, "U, PG & 12 films are available.")]
        [TestCase(13, "U, PG & 12 films are available.")]
        [TestCase(14, "U, PG & 12 films are available.")]



        public void GivenAgeOfViewer_AvailableClassificationsMethod_ReturnsAvailableClassifications(int ageOfViewer, string
            Classifications)
        {
            string actualResult = Program.AvailableClassifications(ageOfViewer);
            string expectedResult;

            //Assert.That(actualResult, Is.EqualTo(expectedResult));

        }
    }
}