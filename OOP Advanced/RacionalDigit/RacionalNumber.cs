using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RacionalDigit
{
    internal class RacionalNumber
    {
        public int firstRacional { get; set; }
        public int secondRacional { get; set; }
        public string GetString()
        {
            return $"{firstRacional}/{secondRacional}";
        }
    }
}