using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GenericClass
{
    internal class Box<TValue>
    {
        Stack<TValue> stack = new Stack<TValue>();
        public void Add(TValue value)
        {
            stack.Push(value);
        }
        public TValue Remove()
        {
            return stack.Pop();
        }
    }
}