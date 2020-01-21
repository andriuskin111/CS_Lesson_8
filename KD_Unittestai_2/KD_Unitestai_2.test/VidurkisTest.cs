using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KD_Unittestai_2;
using System.Collections.Generic;

namespace KD_Unitestai_2.test
{
    [TestClass]
    public class VidurkisTest
    {
        [TestMethod]
        public void TikrinamArTeisingaiPaskaiciuojaPirmoTrimestroVidurki()
        {
            // Arrange
           var  mok = new Mokinys();
            mok.trimestras1 = new List<int>();

            mok.trimestras1.Add(10);
            mok.trimestras1.Add(8);
            mok.trimestras1.Add(2);
            mok.trimestras1.Add(4);
            mok.trimestras1.Add(3);
            mok.trimestras1.Add(5);
            mok.trimestras1.Add(7);
            mok.trimestras1.Add(9);
            //Act
            double vidurkis = mok.IsvestiPirmoTrimestroVidurki();
            //Assert
            Assert.AreEqual(vidurkis, 6);
        }

        [TestMethod]
        public void TikrinamArTeisingaiPaskaiciuojaPirmoTrimestroVidurkiKaiTusciasList()
        {
            // Arrange
            var mok = new Mokinys();
            mok.trimestras1 = new List<int>();
            //Act
            double vidurkis = mok.IsvestiPirmoTrimestroVidurki();
            //Assert
            Assert.AreEqual(vidurkis, 0);
        }
    }
}
