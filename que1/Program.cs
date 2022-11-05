using System;

namespace que1
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] nums = {2,7,9,8,4,9,4,2};
              int original = 4;
             Console.WriteLine(CheckNumber(nums,original));
        }  
        public static int CheckNumber(int[] nums, int original)
        {
            for(int a = 0; a < nums.Length; a++)
            {
                if(original == nums[a])
                {
                    original = 2 * original;
                }
            }
            return original;
        }
                                
    }
}  
