using System;

namespace lesson4
{
    public class Find
    {
        public static int GoodSolution(int[] array, int target)
        {
            int ans = 0;
            int left = 0;
            int right = 0;
            int currentSum = 0;

            while (right < array.Length)
            {
                currentSum += array[right]; 
                while (currentSum > target && left <= right) 
                {
                    currentSum -= array[left]; 
                    left++;  
                }
                if (currentSum <= target) 
                {
                    ans = Math.Max(ans, right - left + 1); 
                }
                right++;
            }
            return ans;
        }

        public static void Main(string[] args)
        {
            int[] array = { -10, -2, 0, 3, 6, 12, 20 };
            int target = 1;
            int i = GoodSolution(array, target);
            Console.WriteLine(i); 
        }
    }
}