using System;
using System.Collections.Generic;
namespace _09
{
    public static class Predicates
    {
        public static List<Func<int, bool>> predicates = new List<Func<int, bool>>();

        public static void AddPredicate(Func<int, bool> predicate)
        {
            predicates.Add(predicate);
        }

        public static List<int> ApplyPredicates(List<int> numbers)
        {
            List<int> result = new List<int>();
            bool legal = true;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                foreach (var predicate in predicates)
                {
                    if (!predicate(currentNumber))
                    {
                        legal = false;
                        break;
                    }
                }
                if (legal)
                {
                    result.Add(currentNumber);
                }
                legal = true;
            }
            return result;
        }
    }
}
