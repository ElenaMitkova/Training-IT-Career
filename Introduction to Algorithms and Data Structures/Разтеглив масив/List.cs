using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
namespace Разтеглив_масив
{
    internal class Custom
    {
        private int[] array;
        public int Count { get; private set; }
        public int this[int index]
        {
            get
            {
                ValidateIndex(index);
                return array[index];
            }
            set
            {
                ValidateIndex(index);
                array[index] = value;
            }
        }
        public void Add(int value)
        {
            IfNeed();
            array[Count] = value;
            Count++;
        }
        private void IfNeed()
        {
            if (Count == array.Length) Grow();
        }
        public void Grow()
        {
            int[] newLIst = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newLIst[i] = array[i];
            }
            array = newLIst;
        }
        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= Count) throw new ArgumentOutOfRangeException("index");
        }
        private void ShiftRight(int index)
        {
            for (int i = Count - 1; i >= index; i--)
            {
                array[i + 1] = array[i];
            }
        }
        public void Insert(int index, int value)
        {
            if (index == Count)
            {
                Add(value);
                return;
            }
            ValidateIndex(index);
            IfNeed();
            ShiftRight(index);
            array[index] = value;
            Count++;
        }
        private void ShiftLeft(int index)
        {
            for (int i = index; i <= Count; i++)
            {
                array[i] = array[i + 1];
            }
        }
        public void RemoveAt(int index)
        {
            ValidateIndex(index);
            ShiftLeft(index);
            Count--;
        }
    }
}