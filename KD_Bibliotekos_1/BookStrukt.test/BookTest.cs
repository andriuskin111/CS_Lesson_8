using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookStruct;

namespace BookStrukt.test
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void TestuojamNameGet()
        {
            // Arrange
            Book knyga;
            knyga.Name = "Knyga";
            knyga.Id = "1234";

            // Act
            string locId = knyga.LocalId; 
            // Assert
            Assert.AreEqual("Knyga1234", locId);
        }

        [TestMethod]
        public void TestuojamNameGetKaiNameYraTuscias()
        {
            // Arrange
            Book knyga;
            knyga.Name = "";
            knyga.Id = "1234";

            // Act
            string locId = knyga.LocalId;
            // Assert
            Assert.AreEqual("1234", locId);
        }

        [TestMethod]
        public void TestuojamNameGetKaiNameIrIdYraTuscias()
        {
            // Arrange
            Book knyga;
            knyga.Name = "";
            knyga.Id = "";

            // Act
            string locId = knyga.LocalId;
            // Assert
            Assert.AreEqual("", locId);
        }
    }
}
