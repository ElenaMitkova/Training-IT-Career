using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UniversalBox
{
    internal class Box<TType>
    {
        public TType Value { get; set; }
        public override string ToString()
        {
            return $"{Value.GetType().FullName}: {Value}";
        }
    }
}