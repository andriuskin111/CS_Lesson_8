using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointStruct;
using RectangleStruct;

namespace NdSavarankiskasDarbasTrys.test
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void TestuojamArTaskasYraStaciakampioViduje()
        {
            // Arrange
            Point point = new Point(10, 20);
            Point topLeft = new Point(1, 8);
            Point bootomRight = new Point(20, 40);
            Rectangle rectangle = new Rectangle(topLeft, bootomRight);

            //Act
            bool rezultatas = rectangle.IsPointInRectangle(point);

            //Assert
            Assert.AreEqual(rezultatas, true);
        }

        [TestMethod]
        public void TestuojamArTaskasNeraStaciakampioViduje()
        {
            // Arrange
            Point point = new Point(0, 20);
            Point topLeft = new Point(1, 8);
            Point bootomRight = new Point(20, 40);
            Rectangle rectangle = new Rectangle(topLeft, bootomRight);

            //Act
            bool rezultatas = rectangle.IsPointInRectangle(point);

            //Assert
            Assert.AreEqual(rezultatas, false);
        }
    }
}
