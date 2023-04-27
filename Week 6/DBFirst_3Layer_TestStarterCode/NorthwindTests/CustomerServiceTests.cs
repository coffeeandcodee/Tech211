using Microsoft.EntityFrameworkCore;
using NorthwindBusiness;
using NorthwindData;
using NUnit.Framework;
using System.Linq;

//TO DO: Finish testing CustomerService.cs
namespace NorthwindTests;

public class CustomerServiceTests
{
    private CustomerService _sut;
    private NorthwindContext _context;
    Customer testCustomer = new Customer()
    {
        CustomerId = "TESTC",
        ContactName = "Test Customer",
        City = "Testville",
        CompanyName = "Test Inc."
    };

    [SetUp]
    public void OneTimeSetup()
    {
        var options = new DbContextOptionsBuilder<NorthwindContext>()
            .UseInMemoryDatabase(databaseName: "Example_DB").Options;

        _context = new NorthwindContext(options);
        _sut = new CustomerService(_context);

        //Seeding in memory database with some test data

        _context.Customers.Add(new Customer()
        {
            CustomerId = "JACOB",
            ContactName = "Jacob Banyard",
            City = "Beijing",
            CompanyName = "SpartaGlobal"
        });

        _context.Customers.Add(new Customer()
        {
            CustomerId = "DANIM",
            ContactName = "Danielle Massey",
            City = "Reykjavik",
            CompanyName = "SpartaGlobal"
        });

        _context.SaveChanges();


    }

    [Test]

    public void GivenValidID_Read_ReturnsCustomer()
    {
        //arrange

        //act
        var c = _sut.Read("JACOB");

        //Assert
        Assert.That(c, Is.Not.Null);
        Assert.That(c, Is.TypeOf<Customer>());
        Assert.That(c.ContactName, Is.EqualTo("Jacob Banyard"));
        Assert.That(c.CompanyName, Is.EqualTo("SpartaGlobal"));
        Assert.That(c.City, Is.EqualTo("Beijing"));



    }

    [Test]
    public void ReadAll_ReturnsListOfExpectedLength()
    {

        //returns correct length
        Assert.That(_sut.ReadAll().Count(), Is.EqualTo(2));
    }
    [Test]

    //public void GivenValidInput_CreateReturns
    public void GivenCustomer_CreateAddsNewCustomer()
    {
        //Arrange (done prior with test customer)
        var countBefore = _sut.ReadAll().Count();
        //act
        _sut.Create(testCustomer);

        Assert.That(_sut.ReadAll().Count(), Is.EqualTo(countBefore + 1));


    }











}
