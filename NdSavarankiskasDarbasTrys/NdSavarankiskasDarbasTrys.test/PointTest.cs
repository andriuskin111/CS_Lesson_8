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

            Point point;
            point.koordinateX = 5;
            point.koordinateY = 5;

            Rectangle rectangle = new Rectangle();
            rectangle.topLeft.koordinateX = 1;
            rectangle.topLeft.koordinateY = 1;
            rectangle.bottomRight.koordinateX = 10;
            rectangle.bottomRight.koordinateY = 10;

            //Act
            bool rezultatas = rectangle.IsPointInRectangle(point);

            //Assert
            Assert.AreEqual(rezultatas, true);
        }

        [TestMethod]
        public void TestuojamArTaskasNeraStaciakampioViduje()
        {
            // Arrange

            Point point;
            point.koordinateX = 20;
            point.koordinateY = 1;

            Rectangle rectangle = new Rectangle();
            rectangle.topLeft.koordinateX = 1;
            rectangle.topLeft.koordinateY = 1;
            rectangle.bottomRight.koordinateX = 10;
            rectangle.bottomRight.koordinateY = 10;

            //Act
            bool rezultatas = rectangle.IsPointInRectangle(point);

            //Assert
            Assert.AreEqual(rezultatas, false);
        }
    }
}
