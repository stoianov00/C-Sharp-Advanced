using System;
using System.Collections.Generic;
namespace _08.Custom_Comparator
{
    public class Comparator : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if ((x % 2 == 0) && (y % 2 == 1))
            {
                return -1;
            }
            else if((x % 2 == 1) && (y % 2 == 0))
            {
                return 1;
            }
            else
            {
                if (x > y)
                {
                    return 1;
                }
                else if(y > x)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
                
            }
        }
         
    }
    
}
