using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class WinstService
    {
        private readonly IKostDAO iKost;
        private readonly IOpbrengstDAO iOpbrengst;
        public WinstService(IKostDAO iKost, IOpbrengstDAO iOpbrengst)
        {
            this.iKost = iKost;
            this.iOpbrengst = iOpbrengst;
        }
        public decimal Winst
        {
            get
            {
                return (iOpbrengst.TotaleOpbrengst() - iKost.TotaleKost());
            }
        }
        
    }
}
