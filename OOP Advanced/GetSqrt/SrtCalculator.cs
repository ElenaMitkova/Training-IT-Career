using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GetSqrt
{
    internal class SrtCalculator
    {
        public Dictionary<double, double> SrtValues = new Dictionary<double, double>();
        public double GetSrt(int number)
        {
            if (SrtValues.ContainsKey(number))
            {
                return SrtValues[number];
            }
            double sqr = Math.Sqrt(number);
            SrtValues[number] = sqr;
            return sqr;
        }
    }
}