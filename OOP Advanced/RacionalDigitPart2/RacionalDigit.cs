using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacionalDigitPart2
{
    internal class RacionalDigit
    {
        public int firstRacional { get; set; }
        public int secondRacional { get; set; }
        public override string ToString()
        {
            return $"{firstRacional}/{secondRacional}";
        }
    }
}
