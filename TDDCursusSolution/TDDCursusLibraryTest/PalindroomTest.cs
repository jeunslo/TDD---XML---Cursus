using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;


namespace TDDCursusLibraryTest
{
    [TestClass]
    public class PalindroomTest
    {
        [TestMethod]
        public void EenEvenStringIsEenPalindroom()
        {
            Assert.IsTrue(new Palindroom("poloolop").IsPalindroom);
        }
        [TestMethod]
        public void EenOnevenStringIsEenPalindroom()
        {
            Assert.IsTrue(new Palindroom("polokolop").IsPalindroom);
        }
        [TestMethod]
        public void EenLegeStringIsGeenPalindroom()
        {
            Assert.IsFalse(new Palindroom("").IsPalindroom);
        }
        [TestMethod]
        public void EenWhiteSpaceIsGeenPalindroom()
        {
            Assert.IsFalse(new Palindroom(" ").IsPalindroom);
        }
        [TestMethod]
        public void EenKarakterIsGeenPalindroom()
        {
            Assert.IsFalse(new Palindroom("k").IsPalindroom);
        }
        [TestMethod]
        public void EenStringIsGeenPalindroom()
        {
            Assert.IsFalse(new Palindroom("poloilop").IsPalindroom);
        }
        [TestMethod]
        public void EenStringBevatNummersIsEenPalindroom()
        {
            Assert.IsTrue(new Palindroom("pol1o1lop").IsPalindroom);
        }
        [TestMethod]
        public void EenStringBevatTekensIsEenPalindroom()
        {
            Assert.IsTrue(new Palindroom("pol$o$lop").IsPalindroom);
        }
        [TestMethod]
        public void EenStringIsGeenPali()
        {
            Assert.IsFalse(new Palindroom("tkofschop").IsPali);
        }
        [TestMethod]
        public void EenStringIsPali()
        {
            Assert.IsTrue(new Palindroom("pohcsschop").IsPali);
        }
    }
}
