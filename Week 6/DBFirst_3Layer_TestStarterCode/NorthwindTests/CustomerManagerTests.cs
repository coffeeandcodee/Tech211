using NorthwindBusiness;
using NorthwindData;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindTests
{
    public class CustomerTests
    {
        InMemoryService _service = new InMemoryService();
        CustomerManager _customerManager;
        NorthwindContext _db;

        [SetUp]
        public void Setup()
        {
            _service.db = new List<Customer>()
            {
                new Customer() {CustomerId = "JOBSS", ContactName = "Steve Jobs", CompanyName = "Apple"},
                new Customer() {CustomerId = "GATEB", ContactName = "Bill Gates", CompanyName = "Microsoft"}
            };
            _customerManager = new CustomerManager(_service);

        }

        [Test]
        public void WhenANewCustomerIsAdded_TheNumberOfCustomersIncreasesBy1()
        {
            int countBefore = _service.db.Count;
            _customerManager.Create("MANDA", "FILL", "FILL", "FILL");
            Assert.That(_service.db.Count, Is.EqualTo(countBefore + 1));


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
            Assert.That(expectedCustomer.ContactName, Is.EqualTo(expectedName));
            Assert.That(expectedCustomer.CompanyName, Is.EqualTo(expectedCompany));
            Assert.That(expectedCustomer.City, Is.EqualTo(expectedCity));

        }

        [Test]
        public void WhenACustomersDetailsAreChanged_TheDatabaseIsUpdated()
        {

            string expectedID = "GATEB";
            string expectedName = "Billy boi";
            string expectedCompany = "Picosoft";

            _customerManager.Update(expectedID, expectedName, expectedCompany);
            Customer updatedCustomer = _service.Read(expectedID);

            //  _customerManager.Update(newGates);
            Assert.That(updatedCustomer.ContactName, Is.EqualTo(expectedName));
            Assert.That(updatedCustomer.CompanyName, Is.EqualTo(expectedCompany));

        }

        [Test]
        public void GUITest_WhenACustomerIsUpdated_SelectedCustomerIsUpdated()
        {
            string expectedID = "JOBSS";
            string expectedName = "MR JOBS";
            string expectedCompany = "BIG APPLE";
            Customer newJobs = new Customer() { CustomerId = "JOBSS", ContactName = expectedName, CompanyName = expectedCompany };

            _customerManager.Update(newJobs.CustomerId);

            Assert.That(_customerManager.SelectedCustomer.CustomerId, Is.EqualTo(expectedID));
            /* Assert.That(updatedCustomer.ContactName, Is.EqualTo(expectedName));
             Assert.That(updatedCustomer.CompanyName, Is.EqualTo(expectedCompany)); */

        }

        [Test]
        public void WhenACustomerIsNotInTheDatabase_Update_ReturnsFalse()
        {
            bool nonExistent = _customerManager.Update("NONE");

            Assert.That(nonExistent.Equals(false));


        }

        [Test]
        public void WhenACustomerIsRemoved_TheNumberOfCustomersDecreasesBy1()
        {
            string ID = "GATEB";

            int countBefore = _service.db.Count();

            Customer toBeDeleted = _service.db.Find(c => c.CustomerId == ID);
          //  _customerManager.Delete(toBeDeleted);


            Assert.That(_service.db.Count, Is.EqualTo(countBefore - 1));

        }

        [Test]
        public void WhenACustomerIsRemoved_TheyAreNoLongerInTheDatabase()
        {
            string ID = "JOBSS";

            Customer toBeDeleted = _service.db.Find(c => c.CustomerId == ID);
           // _customerManager.Delete(toBeDeleted);

            bool exists = _service.db.Any(c => c.CustomerId == ID);

            Assert.That(exists, Is.EqualTo(false));

        }

        [OneTimeTearDown]
        public void TearDown()
        {

        }
    }
}