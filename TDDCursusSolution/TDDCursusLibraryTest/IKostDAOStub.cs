using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    public class IKostDAOStub : IKostDAO
    {
        public decimal TotaleKost()
        {
            return 25m;
        }
    }
}
