using System.Data.SqlClient;

namespace SQLWithCSharp;

public class Program
{
    static void Main(string[] args)
    {
        //Making a connection to database
        using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;
        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
        MultiSubnetFailover=False"))
        {
            var customers = new List<Customer>();
            connection.Open();

            #region Read

            //Making query string
            var query = "SELECT * FROM CUSTOMERS";

            //SqlCommand object created
            //Must also be disposed of, hence using
            using (var command = new SqlCommand(query, connection))
            {
                var sqlReader = command.ExecuteReader();

                //This returns a single row
                sqlReader.Read();

                while (sqlReader.Read())
                {
                    var customer = new Customer();
                    customer.CompanyName = sqlReader["CompanyName"].ToString();
                    customer.City = sqlReader["City"].ToString();
                    customer.ContactName = sqlReader["ContactName"].ToString();
                    customer.ContactTitle = sqlReader["ContactTitle"].ToString();
                    customer.CustomerID = sqlReader["CustomerID"].ToString();
                    customer.Region = sqlReader["Region"].ToString();

                    customers.Add(customer);
                }

                //Reader must also be closed?
                sqlReader.Close();
            }

            #endregion

            #region Create
            var newCustomer = new Customer()
            {
                City = "Birmingham",
                CompanyName = "SpartaGlobal",
                ContactName = "Peter Bellaby",
                ContactTitle = "Junior Trainer",
                Region = "WM",
                CustomerID = "SPARP"
            };
            //?? is the null coalescing operator. If something is null, return this instead
            var createQuery = $"INSERT INTO CUSTOMERS(CustomerID, ContactName, CompanyName, ContactTitle, City, Region) VALUES ('{newCustomer.CustomerID}', '{newCustomer.ContactName}', '{newCustomer.CompanyName}', '{newCustomer.ContactTitle}', '{newCustomer.City}', '{newCustomer.Region})'";


            using (var createCommand = new SqlCommand(createQuery, connection))
            {
                //"ExecuteNonQuery" as in execute without response expected
                createCommand.ExecuteNonQuery();
            }


            #endregion

            #region Update

            //rewatch recording from this bit
            var updateQuery = $"UPDATE CUSTOMERS SER Region - NULL WHERE Customer ID = 'SPARP'";


            
            using (var updateCommand = new SqlCommand(updateQuery, connection))
            {
                updateCommand.ExecuteNonQuery();
            }

            #endregion

            #region Delete

            var deleteQuery = $"DELETE FROM CUSTOMERS WHERE CustomerID = 'SPARP'";

            using (var deleteCommand = new SqlCommand(deleteQuery, connection))
            {
                deleteCommand.ExecuteNonQuery();
            }

            #endregion


        }

        //Connections should be closed later
        //The using stateement then block specifies
        //connection is closed after exiting scope




    }
}