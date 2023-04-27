using Moq;
using NorthwindBusiness;
using NorthwindData;
using NUnit.Framework;
using System;



namespace NorthwindTests;

public class CustomerManagerMoq
{
    private CustomerManager _sut;

    [Test]
    public void BeAbleToBeConstructed()
    {
        _sut = new CustomerManager(new Mock<ICustomerService>().Object);

        Assert.That(_sut, Is.TypeOf<CustomerManager>());
        Assert.That(_sut, Is.Not.Null);

    }

    [Test]
    [Category("Happy Path")]
    public void WhenUpdateCalledWithValidID_ReturnTrue()
    {
        //ararange
        var mockCustomerService = new Mock<ICustomerService>();
        var customerToUpdate = new Customer()
        {
            CustomerId = "BOB",
            ContactName = "Bob Marley",
            City = "Kingstown"
        };

        //Setting up the 
        mockCustomerService.Setup(cs => cs.Read("BOB")).Returns(customerToUpdate);

        _sut = new CustomerManager(mockCustomerService.Object);

        //act
        var result = _sut.Update("BOB", It.IsAny<string>(), It.IsAny<string>(),
            It.IsAny<string>(), It.IsAny<string>());

        Assert.That(result, Is.True);

    }
    [Test]
    [Category("Happy Path")]
    public void WhenUpdateCalledWithValidID_UpdateSelectedCustomer()
    {
        //ararange
        var mockCustomerService = new Mock<ICustomerService>();
        var customerToUpdate = new Customer()
        {
            CustomerId = "BOB",
            ContactName = "Bob Marley",
            City = "Kingstown"
        };

        //Setting up the 
        mockCustomerService.Setup(cs => cs.Read("BOB")).Returns(customerToUpdate);

        _sut = new CustomerManager(mockCustomerService.Object);

        //act
        _sut.Update("BOB", "Robert Marley", "Jamaica", "Princetown", "JM9");

        Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Bob Marley"));
        Assert.That(_sut.SelectedCustomer.Country, Is.EqualTo("Jamaica"));
        Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Robert Marley"));
        Assert.That(_sut.SelectedCustomer.PostalCode, Is.EqualTo("JM9"));

    }

    [Test]
    [Category("Sad path")]
    public void ReturnFalse_GivenInvalidId()
    {
        var mockCustomerService = new Mock<ICustomerService>();

        mockCustomerService.Setup(cs => cs.Read("NVALID")).Throws(new ArgumentException());
        //mockCustomerService.Setup(cs => cs.Read("NVALID")).Returns((Customer)null);

        _sut = new CustomerManager(mockCustomerService.Object);

        var result = _sut.Update("INVALID", It.IsAny<string>(), It.IsAny<string>(),
            It.IsAny<string>(), It.IsAny<string>());

        Assert.That(result, Is.False);

    }

    [Test]
    [Category("Sad path")]

    public void ReturnFalse_WhenThereIsADatabaseSaveException()
    {
        //arrange
        var mockCustomerService = new Mock<ICustomerService>();
        var customerToUpdate = new Customer()
        {
            CustomerId = "BOB",
            ContactName = "Bob Marley",
            City = "Kingstown"
        };

        mockCustomerService.Setup(cs => cs.Read("BOB")).Returns(customerToUpdate);
        mockCustomerService.Setup(cs => cs.SaveChanges()).Throws<Exception>();

        _sut = new CustomerManager(mockCustomerService.Object);

        var result = _sut.Update("BOB", It.IsAny<string>(), It.IsAny<string>(),
            It.IsAny<string>(), It.IsAny<string>());

        Assert.That(result, Is.False);

    }

    [Test]
    //FINISH THESE MOQ  CRUD TESTS
    [Category ("Happy Path")]

    public void DeleteSelectedCustomer_WhenDeleteCalledOnCustomer()
    {
        //Arrange
        var mockCustomerService = new Mock<ICustomerService>();
        var customerToDelete = new Customer() { CustomerId = "PANDA", ContactName =  "Ama Panda", CompanyName = "Bamboozled" };

        //Setting up the stub
        //Testing Delete by simulating methods returned by Delete call. The way these returns are simulated is called a stub (?)
        //Return() has to return same object type as the read method 
        mockCustomerService.Setup(cs => cs.Read("PANDA")).Returns(customerToDelete);
        mockCustomerService.Setup(cs => cs.Remove(customerToDelete));

       //Act
        _sut = new CustomerManager(mockCustomerService.Object);
        var result = _sut.Delete("PANDA");

        //Assert
        Assert.That(result, Is.True);
    }

    //[Test]
    //public void DeleteReturnsFalse_When


    [Test]
    public void CallSaveChanges_WhenUpdateIsCalled_WithValidId()
    {
        //arrange
        var mockCustomerService = new Mock<ICustomerService>();
        mockCustomerService.Setup(cs => cs.Read("MATT")).Returns(new Customer());
        _sut = new CustomerManager(mockCustomerService.Object);

        //act
        _sut.Update("MATT", "", "", "", "");

        //Assert
        mockCustomerService.Verify(cs => cs.SaveChanges(), Times.AtLeastOnce);
        //Assert.Pass();
    }

    //Loose behaviour is the defaule setting

    [Test]
    public void NoStubsTest()
    {
        //arrange
        var mockCustomerService = new Mock<ICustomerService>(MockBehavior.Strict);

        _sut = new CustomerManager(mockCustomerService.Object);

        //act
        var result = _sut.Update("MATT", "", "", "");

        //Assert.Pass();

    }


}
