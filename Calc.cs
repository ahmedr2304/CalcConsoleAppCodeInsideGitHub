using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcConsoleAppCodeInside
{
     public class Calc
    {
        public int Average(int[] nums) 
        {
            int total = 0;
            foreach (int num in nums) 
            {
                total +=  num;
            }
            return total/nums.Count();   
        }

        public int Smallest(int[] nums)
        {
            int Smallest = nums[0];
            foreach (int num in nums)
            {
                if (num<Smallest  ) 
                {
                    Smallest = num;
                }
                
            }
            return Smallest;
        }
        public int Largest(int[] nums)
        {
            int Largest = nums[0];
            foreach (int num in nums)
            {
                if (num > Largest)
                {
                    Largest = num;
                }

            }
            return Largest;
        }

    }
}
