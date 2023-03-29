using LAB1_UnitTests;

//NOTE - Ages assumed to be integer values (i.e upper age bound for those who can only watch U & PG is 11)

namespace Classification_Tests
{
    public class Tests
    {
        //Test cases for 0 <= age < 12 range
        [TestCase(0, "U & PG films available.")]    //Test cases consist of the two bounds as input (in this case, 0 & 11) and a
        [TestCase(7, "U & PG films available.")]    //As well as an arbitrary point within range, in this case 7
        [TestCase(11,"U & PG films available.")]

        //Test cases for 12 <= age < 15 range
        [TestCase(12, "U, PG & 12 films available.")]
        [TestCase(13, "U, PG & 12 films available.")]
        [TestCase(14, "U, PG & 12 films available.")]

        //Test cases for 15 <= age < 18 range
        [TestCase(15, "U, PG, 12 & 15 films available.")]
        [TestCase(16, "U, PG, 12 & 15 films available.")]
        [TestCase(17, "U, PG, 12 & 15 films available.")]

        //Test cases for ages >= 18
        [TestCase(18, "All films are available.")]
        [TestCase(18, "All films are available.")]


        public void GivenAgeOfViewer_AvailableClassificationsMethod_ReturnsAvailableClassifications(int ageOfViewer, string
            expectedResult)
        {
            string actualResult = Program.AvailableClassifications(ageOfViewer);

            Assert.That(expectedResult, Is.EqualTo(actualResult));


        }
    }
}