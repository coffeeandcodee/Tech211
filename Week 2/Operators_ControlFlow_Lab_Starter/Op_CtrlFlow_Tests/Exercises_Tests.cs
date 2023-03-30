using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;
namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        #region MyMethod Tests
        // write unit test(s) for MyMethod here
        [TestCase(10, 5, true)]
        [TestCase(-99, 3, true)]
        [TestCase(42, 10, false)]
        [TestCase(8, 8, false)]

        public void WhenTwoNumbersSupplied_ReturnsCorrectBool(int num1, int num2, bool expectedResult)
        {
            bool actualResult = Exercises.MyMethod(num1, num2);
            Assert.That(actualResult, Is.EqualTo(expectedResult));


        }
        #endregion


        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() { };
            Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }
        #region TicketType tests
        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            //Assert.That(result, Is.EqualTo(expected));
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion

        

        #region Grade method test
        [TestCase(0, "Fail")]
        [TestCase(20, "Fail")]
        [TestCase(39, "Fail")]
        [TestCase(40, "Pass")]
        [TestCase(50, "Pass")]
        [TestCase(59, "Pass")]
        [TestCase(60, "Pass with Merit")]
        [TestCase(68, "Pass with Merit")]
        [TestCase(74, "Pass with Merit")]
        [TestCase(75, "Pass with Distinction")]
        [TestCase(85, "Pass with Distinction")]
        [TestCase(100, "Pass with Distinction")]

        public void GradeTest(int mark, string expected)
        {
            string result = Exercises.Grade(mark);

            Assert.That(result, Is.EqualTo(expected));
        }


        #endregion

        //    Level | Max attendees
        //------|--------------
        //4 | 20
        //3 | 50
        //2 | 50
        //1 | 100
        //0 | 200

        [TestCase(0, 200)]
        [TestCase(1, 100)]
        [TestCase(2, 50)]
        [TestCase(3, 50)]
        [TestCase(4, 20)]

        public void WhenGivenCovidLevel_WhenMaxWeddingsNumbersCalled_ThenValueReturns(int level, int expected)
        {

            int result = Exercises.GetScottishMaxWeddingNumbers(level);

            Assert.That(result, Is.EqualTo(expected));
        }
    }

}
