using ACM;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FirstNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void LastNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
