using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PirkinysStruct;

namespace NdStrukturosInkapsuliacija1.test
{
    [TestClass]
    public class PirkinysTest
    {
        [TestMethod]
        public void TestuojamArTeisingaiSuskaiciosVisaPirkiniuKaina()
        {
            // Arrange
            Pirkinys pirkinys1 = new Pirkinys("Alus", 5, 2m);

            // Act
            decimal kainaViso = 10;

            // Assert
            Assert.AreEqual(kainaViso, pirkinys1.KainaViso);
        }

        [TestMethod]
        public void TestuojamArTeisingaiSuskaiciosVisaPirkiniuKainaKaiNeraPrekiu()
        {
            // Arrange
            Pirkinys pirkinys1 = new Pirkinys("", 0, 0m);

            // Act
            decimal kainaViso = 0;

            // Assert
            Assert.AreEqual(kainaViso, pirkinys1.KainaViso);
        }
    }
}
