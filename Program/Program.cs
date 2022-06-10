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

        private void Question1(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"[{nums[i]}, {nums[j]}]");
                    }
                }
            }
        }

        private void Question5(int n)
        {

        }
    }
}
