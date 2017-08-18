using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Tests
{
    [TestClass()]
    public class VendorTests
    {
        [TestMethod()]
        public void RetrieveWithKeysTest()
        {
            //Arrange
            var repository = new Vendor();
            var expected = new Dictionary<string, Vendor>()
            {
                 { "ABC Corp",new Vendor()
                   { VendorId=5,CompanyName="ABC Corp", Email="abc@abc.com"} },
                { "XYZ Inc",new Vendor()
                   { VendorId=8,CompanyName="XYZ Inc", Email="abc@xyz.com"} },
            };

            //Act
            var actual = repository.RetrieveWithKeys();

            //Assert
            CollectionAssert.AreEqual(expected,actual);
            //Assert.Fail();
        }
    }
}