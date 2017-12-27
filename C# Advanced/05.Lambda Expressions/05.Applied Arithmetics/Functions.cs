using System;
using System.Collections.Generic;
namespace _05.Applied_Arithmetics
{
    
    public static class Functions
    {
        public static void Print(List<int> collection, Action<List<int>> action)
        {
            action(collection);
        }

        public static List<int> ApplyFunc(List<int> collection, Func<int, int> func)
        {
            List<int> result = new List<int>();
            foreach (var item in collection)
            {
                result.Add(func(item));
            }
            return result;
        }
        
    }
   
}
