using AdvancedNUnit;
namespace AdvancedNUnitTests
{
    public class CalculatorTests
    {
        //subject under test
        private Calculator _sut;

        //OneTimeSetUp RUNS ONCE
        //Appropriate when connecting to a database. 
        //Connection should be done ONCE
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            //do something once before tests
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            //do something oce after tests.
            //e.g close connection make to a database made in 
            // 
        }
        //SetUp  executes before every test
        [SetUp]
        public void Setup()
        {
            _sut = new Calculator();
            //Rather than create _sut before every test

        }

        //TearDown runs after every test method
        [TearDown]
        public void TearDown()
        {
            //executes after every test
        }

        //--------------------------------

        //Recall "Arrange, Act, Assert". 



        [Test]
        public void Add_Always_ReturnsExpectedResult()
        { //Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = 2, Num2 = 4 };

            // Act
            var result = subject.Add();

            // Assert
            //You can add an optional failure message as third argument

            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");

        }

        [Test]

        public void SomeConstraints()
        {
            //sut = subject under test
          
            _sut.Num1 = 4;
            _sut.Num2 = 2;

            Assert.That(_sut.IsDivisible());
            _sut.Num2 = 3;
            Assert.That(_sut.IsDivisible(), Is.False);
            Assert.That(_sut.ToString(), Does.Contain("Calculator"));
            //Assert.That(_sut, Is.InstanceOf());

        }

        //These square bracket tags are known as attributes
        [Ignore("message")]
        [Test]

        public void TestARrayOfStrings()
        {
            var fruit = new List<string> { "mange", "peach", "kiwi" };


        }

        
      }
}