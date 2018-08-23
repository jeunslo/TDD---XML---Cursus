using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;
using System.Collections.Generic;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class PersoonTest
    {
        private List<string> lijst;
        [TestInitialize]
        public void Initialize()
        {
            lijst = new List<string>();
        }
        [TestMethod]
        public void EenVoornamenVerzamelingMetMeerdereItems()
        {
            lijst.Add("Jan");
            lijst.Add("Piet");
            new Persoon(lijst);
        }
        [TestMethod]
        public void EenVoornamenVerzamelingMetEénItem()
        {
            lijst.Add("Jan");
            new Persoon(lijst);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenVoornamenVerzamelingMetGeenItemsIsVerkeerd()
        {
            new Persoon(lijst);
        }
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void EenNullVoornamenVerzamelingIsVerkeerd()
        {
            new Persoon(null);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenVoornamenVerzamelingMetTweeDezelfdeVoornamenIsVerkeerd()
        {
            lijst.Add("Jan");
            lijst.Add("Piet");
            lijst.Add("Jan");
            new Persoon(lijst);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenVoornamenVerzamelingMetEénVoornaamInHoofdletterEnAndereInKleineIsVerkeerd()
        {
            lijst.Add("JAN");
            lijst.Add("Piet");
            lijst.Add("Jan");
            new Persoon(lijst);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenVoornamenVerzamlingBestaandeUitGeenAlfanumeriekeTekensIsVerkeerd()
        {
            lijst.Add("%?!");
            new Persoon(lijst);
        }
        [TestMethod]
        public void EenVoornamenVerzamlingMetMinstensEénAlfanumeriekeTekenIsCorrect()
        {
            lijst.Add("%?!3");
            new Persoon(lijst);
        }
        [TestMethod]
        public void ToStringMoetDeVoornamenTeruggeven()
        {
            lijst.Add("Piet");
            lijst.Add("Jan");
            var persoon = new Persoon(lijst);
            Assert.AreEqual("Piet Jan ", persoon.ToString());
        }

    }
}
