using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        private int[] Question1(int[] nums, int target)
        {
            int[] result = new int[2];
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return result;
        }

        private void Question4(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        nums[j] = nums[i];
                        nums[i] = nums[j];
                    }
                }
            }
        }

        private bool Question6(int n)
        {
            if(n % 4 == 0 || n == 1)
            {
                return true;
            }
            return false;
        }
    }
}
