using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // - Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            // - Act 
            var actual = StringHandler.InsertSpaces(source);

            // - Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
