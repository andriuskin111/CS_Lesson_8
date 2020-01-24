using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiskasStruct;
using System.Collections.Generic;

namespace NdSavarankiskasDarbasKeturi.test
{
    [TestClass]
    public class MiskasTest
    {
        [TestMethod]
        public void TestuojamArPasodinoDvidesimtMedziu()
        {
            // Arrange
            var miskas = new Miskas();
            miskas.medziai = new List<int>();

            // Act
            int medziuSkaicius = 20;

            for (int i = 0; i < medziuSkaicius; i++)
            {
                miskas.PasodintiMedi();
            }           

            // Assert
            Assert.AreEqual(medziuSkaicius, miskas.medziai.Count);
        }
    }
}
