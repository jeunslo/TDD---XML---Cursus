using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;
using Moq;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class LandServiceTest
    {
        private Mock<ILandDAO> mockFactory;
        private ILandDAO landDao;
        private LandService landService;
        [TestInitialize]
        public void Initialize()
        {
            mockFactory = new Mock<ILandDAO>();
            landDao = mockFactory.Object;
            mockFactory.Setup(eenLandDAO => eenLandDAO.OppervlakteAlleLanden()).Returns(20);
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("B")).Returns(new Land { Landcode = "B", Oppervlakte = 5 });
            landService = new LandService(landDao);
        }
        [TestMethod]
        public void VerhoudingOppervlakteLandtovOppervlakteAlleLanden()
        {
            Assert.AreEqual(0.25m, landService.VerhoudingOppervlakteLandtovOppervlakteAlleLanden("B"));
            mockFactory.Verify(eenLandDAO => eenLandDAO.OppervlakteAlleLanden());
            mockFactory.Verify(eenLandDAO => eenLandDAO.Read("B"));
        }
    }
}
