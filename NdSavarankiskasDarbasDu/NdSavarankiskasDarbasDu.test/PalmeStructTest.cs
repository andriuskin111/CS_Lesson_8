using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalmeStruct;

namespace NdSavarankiskasDarbasDu.test
{
    [TestClass]
    public class PalmeStructTest
    {
        [TestMethod]
        public void TestuojamArTeisingaiPaskaiciuosVaisius()
        {
            // Arrange
            Palme palme;
            palme.amzius = 8;
            palme.vaisiuKiekis = 0;

            // Act
            palme.PridetiVienaMenesiAmziaus();
            int vaisiaiRezultatas = palme.VaisiuKiekis;
            
            // Assert
            Assert.AreEqual(vaisiaiRezultatas, 12);
        }

        [TestMethod]
        public void TestuojamArTeisingaiPaskaiciuosVaisiusKaiPalmesAmziusMaziauUzPenkis()
        {
            // Arrange
            Palme palme;
            palme.amzius = 4;
            palme.vaisiuKiekis = 0;

            // Act
            palme.PridetiVienaMenesiAmziaus();
            int vaisiaiRezultatas = palme.VaisiuKiekis;

            // Assert
            Assert.AreEqual(vaisiaiRezultatas, 0);
        }

        [TestMethod]
        public void TestuojamArTeisingaiPaskaiciuosVaisiusKaiPalmesAmziusDaugiauUzDvylika()
        {
            // Arrange
            Palme palme;
            palme.amzius = 13;
            palme.vaisiuKiekis = 0;

            // Act
            palme.PridetiVienaMenesiAmziaus();
            int vaisiaiRezultatas = palme.VaisiuKiekis;

            // Assert
            Assert.AreEqual(vaisiaiRezultatas, 0);
        }
    }
}
