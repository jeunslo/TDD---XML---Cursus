using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class VeilingTest1
    {
        private Veiling veiling;
        [TestInitialize]
        public void Initialize()
        {
            veiling = new Veiling();
        }
        [TestMethod]
        public void StandaardHoogsteBodIsNull()
        {
            Assert.AreEqual(decimal.Zero, veiling.HoogsteBod);
        }
        [TestMethod]
        public void HoogsteBodIsGelijkAanDoeBod()
        {
            var bedrag = veiling.DoeBod(1000m);
            Assert.AreEqual(bedrag, veiling.HoogsteBod);
        }
        [TestMethod]
        public void HoogsteBodIsGelijkAanHoogstGebodenBedrag()
        {
            veiling.DoeBod(1000m);
            veiling.DoeBod(4000m);
            veiling.DoeBod(2000m);
            Assert.AreEqual(4000m, veiling.HoogsteBod);
        }
    }
}
