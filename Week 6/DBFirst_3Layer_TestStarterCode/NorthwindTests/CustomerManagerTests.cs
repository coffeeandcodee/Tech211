using NUnit.Framework;
using NorthwindBusiness;
using NorthwindData;
using System.Linq;
using System.Collections.Generic;

namespace NorthwindTests
{
    public class CustomerTests
    {
        InMemoryService _service = new InMemoryService();
        CustomerManager _customerManager;
        NorthwindContext _db;

        [OneTimeSetUp]
        public void Setup()
        {
            _service.db = new List<Customer>()
            { 
                new Customer() {CustomerId = "AHMI"},
                new Customer() {CustomerId = "PIKAC"}
            };
            _customerManager = new CustomerManager(_service);
            // remove test entry in DB if present
            
           /* using (var db = new NorthwindContext())
                _
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "MANDA"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }*/
        }

        [Test]
        public void WhenANewCustomerIsAdded_TheNumberOfCustemersIncreasesBy1()
        {
            int countBefore = _service.db.Count;
            _customerManager.Create("MANDA", "FILL", "FILL", "FILL");
            Assert.That(_service.db.Count, Is.EqualTo(countBefore + 1));
           // Assert.That();

        }

        [Test]
        public void WhenANewCustomerIsAdded_TheirDetailsAreCorrect()
        {  
           var expectedId = "TESTJ"; 
           var expectedName = "John Test"; 
           var expectedCompany = "Test Inc."; 
           var expectedCity = "Testville"; 

           _customerManager.Create(expectedId, expectedName, expectedCompany, expectedCity);
            var expectedCustomer = _service.db.Find(e => e.CustomerId == expectedId);

            Assert.That(expectedCustomer.CustomerId, Is.EqualTo(expectedId));
            Assert.That(expectedCustomer.ContactName, Is.EqualTo(expectedId));
            Assert.That(expectedCustomer.CompanyName, Is.EqualTo(expectedCompany));
            Assert.That(expectedCustomer.City, Is.EqualTo(expectedCity));
            
        }

        [Test]
        public void WhenACustomersDetailsAreChanged_TheDatabaseIsUpdated()
        {

        }

        [Test]
        public void WhenACustomerIsUpdated_SelectedCustomerIsUpdated()
        {

        }

        [Test]
        public void WhenACustomerIsNotInTheDatabase_Update_ReturnsFalse()
        {


        }

        [Test]
        public void WhenACustomerIsRemoved_TheNumberOfCustomersDecreasesBy1()
        {

        }

        [Test]
        public void WhenACustomerIsRemoved_TheyAreNoLongerInTheDatabase()
        {

        }

        [OneTimeTearDown]
        public void TearDown()
        {


            using (var db = new NorthwindContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "MANDA"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }
    }
}