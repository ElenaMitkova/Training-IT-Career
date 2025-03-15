using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Numbers
{
    public class Number
    {
        public int A { get; set; }
        public int B { get; set; }
        public override string ToString()
        {
            int a = A;
            int b = B;
            return $"{a / NOD(A, B)}/{b / NOD(A, B)}";
        }
        private int NOD(int a, int b)
        {
            while(b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}
