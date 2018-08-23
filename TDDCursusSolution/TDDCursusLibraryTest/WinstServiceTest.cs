using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;
using Moq;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private IKostDAO iKost;
        private IOpbrengstDAO iOpbrengst;
        private WinstService winstService;
        private Mock<IKostDAO> mockKost;
        private Mock<IOpbrengstDAO> mockOpbrengst;
        [TestInitialize]
        public void Initialize()
        {
            mockKost = new Mock<IKostDAO>();
            mockOpbrengst = new Mock<IOpbrengstDAO>();
            iKost = mockKost.Object;
            iOpbrengst = mockOpbrengst.Object;
            mockKost.Setup(x => x.TotaleKost()).Returns(25m);
            mockOpbrengst.Setup(x => x.TotaleOpbrengst()).Returns(30m);
            winstService = new WinstService(iKost, iOpbrengst);
        }
        [TestMethod]
        public void WinstIsOpbrengstMinKost()
        {
            Assert.AreEqual(5m, winstService.Winst);
            mockKost.Verify(x => x.TotaleKost());
            mockOpbrengst.Verify(x => x.TotaleOpbrengst());
        }
    }
}
