using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PrekeStruct;
using PrekiuSarasasStruct;

namespace NdStrukturosInkapsuliacija2.test
{
    [TestClass]
    public class PrekeTest
    {
        [TestMethod]
        public void TestuojamArTeisingaiSuskaiciuosVisuPrekiuKaina()
        {
            // Arrange
            PrekiuSarasas prekes;
            List<Preke> prekiuSarasas = new List<Preke>();

            prekiuSarasas.Add(new Preke("Alus", 10, 2m));
            prekiuSarasas.Add(new Preke("Degtine", 10, 2m));
            prekiuSarasas.Add(new Preke("Viskis", 10, 2m));
            prekiuSarasas.Add(new Preke("Prezervatyvai", 10, 2m));
            prekiuSarasas.Add(new Preke("Batonas", 10, 2m));

            // Act
            decimal visuPrekiuKaina = prekes.SuskaiciuotiVisaPrekiuKaina(prekiuSarasas);

            // Assert
            Assert.AreEqual(visuPrekiuKaina, 100);
        }

        [TestMethod]
        public void TestuojamArNeuzlusJeiListBusTuscias()
        {
            // Arrange
            PrekiuSarasas prekes;
            List<Preke> prekiuSarasas = new List<Preke>();

            // Act
            decimal visuPrekiuKaina = prekes.SuskaiciuotiVisaPrekiuKaina(prekiuSarasas);

            // Assert
            Assert.AreEqual(visuPrekiuKaina, 0);
        }

        [TestMethod]
        public void TestuojamArTeisingaiSuskaiciuosVisuPrekiuKainaKaiKiekiaiNulis()
        {
            // Arrange
            PrekiuSarasas prekes;
            List<Preke> prekiuSarasas = new List<Preke>();

            prekiuSarasas.Add(new Preke("Alus", 0, 2m));
            prekiuSarasas.Add(new Preke("Degtine", 0, 2m));
            prekiuSarasas.Add(new Preke("Viskis", 0, 2m));
            prekiuSarasas.Add(new Preke("Prezervatyvai", 0, 2m));
            prekiuSarasas.Add(new Preke("Batonas", 0, 2m));

            // Act
            decimal visuPrekiuKaina = prekes.SuskaiciuotiVisaPrekiuKaina(prekiuSarasas);

            // Assert
            Assert.AreEqual(visuPrekiuKaina, 0);
        }

        [TestMethod]
        public void TestuojamArTeisingaiSuskaiciuosVisuPrekiuKainaKaiKainosYraNulis()
        {
            // Arrange
            PrekiuSarasas prekes;
            List<Preke> prekiuSarasas = new List<Preke>();

            prekiuSarasas.Add(new Preke("Alus", 10, 0m));
            prekiuSarasas.Add(new Preke("Degtine", 10, 0m));
            prekiuSarasas.Add(new Preke("Viskis", 10, 0m));
            prekiuSarasas.Add(new Preke("Prezervatyvai", 10, 0m));
            prekiuSarasas.Add(new Preke("Batonas", 10, 0m));

            // Act
            decimal visuPrekiuKaina = prekes.SuskaiciuotiVisaPrekiuKaina(prekiuSarasas);

            // Assert
            Assert.AreEqual(visuPrekiuKaina, 0);
        }
    }
}
