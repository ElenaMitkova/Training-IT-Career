using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ScaleClass
{
    internal class Scale<T>
    {
        private Comparer<T> comparer;
        private T Right;
        private T Left;
        public Scale(T Right, T Left)
        {
            comparer = Comparer<T>.Default;
            this.Right = Right;
            this.Left = Left;
        }
        public T Compare(T right, T left)
        {
            if (comparer.Compare(right, left) < 0)
            {
                return left;
            }
            if (comparer.Compare(right, left) > 0)
            {
                return right;
            }
            return default;
        }
    }
}