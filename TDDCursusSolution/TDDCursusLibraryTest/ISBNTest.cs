using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class ISBNTest
    {
        [TestMethod]
        public void EenCorrecteISBN()
        {
            new ISBN(9789027439642L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ISBNMet14CijfersIsVerkeerd()
        {
            new ISBN(97890274396423L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ISBNMet12CijfersIsVerkeerd()
        {
            new ISBN(978902743964L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenVerkeerdeISBNControle()
        {
            new ISBN(9789027439643L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void HetNummer0IsVerkeerd()
        {
            new ISBN(0L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EenNegatiefNummerIsVerkeerd()
        {
            new ISBN(-9789027439642L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenVerkeerdeISBNControle0()
        {
            new ISBN(9789027439640L);
        }
        [TestMethod]
        public void EenCorrecteISBNMetControle0()
        {
            new ISBN(9789227439640L);
        }
    }
}
