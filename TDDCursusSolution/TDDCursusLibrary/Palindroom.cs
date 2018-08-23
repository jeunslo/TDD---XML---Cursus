using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Palindroom
    {
        private readonly string palindroom;
        public Palindroom(string palindroom)
        {
            this.palindroom = palindroom;
        }
        public bool IsPalindroom
        {
            get
            {
                if (palindroom.Length == 1 || string.IsNullOrWhiteSpace(palindroom) || string.IsNullOrEmpty(palindroom))
                    return false;
                var j = palindroom.Length-1;
                for (var i = 0; i < (palindroom.Length / 2); i++)
                {
                    if (palindroom[i] != palindroom[j])
                            return false;
                    j--;
                }
                return true;
            }
        }
        public bool IsPali
        {
            get
            {
                string omgekeerd = new string(palindroom.ToArray().Reverse().ToArray());
                return palindroom == omgekeerd;
            }
        }
    }
}
