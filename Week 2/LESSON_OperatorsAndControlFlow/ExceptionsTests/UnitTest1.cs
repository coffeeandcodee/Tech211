namespace ExceptionsTests;
using OperatorsAndControlFlow;
using Loops;

public class Tests
{
    [TestFixture] public class LoopTests
    {
        
        #region ForLoop
        //Using Params test
        [TestCase(22, 0, -1, 2, -3, 22)]
        [TestCase(22, 15, -1213, 2, -3, 22)]
        [TestCase(-10, -32, -11, -24, -30, -12)]
        [TestCase(54, 54, -1, 2, -3, 22)]
        public void GivenList_ReturnsHighestIntegerFor(int expectedResult, params int[] numbers)
        {   //.ToList() method can be used to turn array into list
            int actualResult = LoopExamples.HighestForLoop(numbers.ToList());
            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }
        #endregion
        #region ForEachLoop
        [TestCase(22, 0, -1, 2, -3, 22)]
        [TestCase(22, 15, -1213, 2, -3, 22)]
        [TestCase(-10, -32, -11, -24, -30, -12)]
        [TestCase(54, 54, -1, 2, -3, 22)]

        public void GivenList_ReturnsHighestIntegerForEach(int expectedResult, params int[] numbers)
        {

        }

        #endregion
        
    }


    //Arrange
    [TestCase(-20)]
    [TestCase(-1)]
    [TestCase(101)]
    [TestCase(140)]
    public void GivenInvalidData_GetGrade_ThrowsArgumentOutOfBoundsException(int grade)
    {
        //Act. We NEVER get to this result assignment because exception is thrown prior (see GetGrade method)
        //string result = Program.GetGrade(grade);

        //lambda expression. => is the lambda operator

        //Can have multiple Asserts. These two Asserts are independent 


        Assert.That(() => Program.GetGrade(grade), Throws.TypeOf<ArgumentOutOfRangeException>());
        //   .With.Message.Contain("'grade' needs to be between 0 and 100"));
        Assert.That(() => Program.GetGrade(grade), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain("'grade' needs to be between 0 and 100"));

        //Assert
    }
}