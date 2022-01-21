using ACM.bl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Aliasgar",
                LastName = "Gandhi"
            };
            string actual = "Gandhi, Aliasgar";

            //Act
            string expected = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
