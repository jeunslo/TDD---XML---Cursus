using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Veiling
    {
        private decimal hoogsteBodValue;
        public decimal DoeBod(decimal bedrag) => hoogsteBodValue = (bedrag > hoogsteBodValue) ? bedrag : hoogsteBodValue;
       
        public decimal HoogsteBod => hoogsteBodValue;
    }
}
