﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GenericClas
{
    internal class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] result = new T[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = item;
            }
            return result;
        }
    }
}