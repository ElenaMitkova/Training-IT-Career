using System;
namespace Разтеглив_масив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Custom list = new Custom();
            list.Add(15);
            int index = list[0];
            list.Insert(0, index);
            list.RemoveAt(0);
            //foreach (var item in list)
            //{
                
            //}
        }
    }
}