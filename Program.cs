using System;
using System.Security.AccessControl;
namespace lesson3

{
    internal class SolutionTwoPointers
    {
        static void Main(string[] args)
        {
            char[] arr = new char[] { 'a', 'b', 'c', 'd' };
            Console.WriteLine(Reverse(arr));

            int[] arr1 = new int[] { 2, 1, 7, 3, 10, 1, 2, 11, 15, 4, 3 };
            int[] arr2 = new int[] { };
            int[] arr3 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr4 = new int[] { 21, 23, 24, 124 };
            int[] arr5 = new int[] { 2, 1, 127, 3, 26, 1, 2, 11, 15, 4, 3 };

            Console.WriteLine(BadSolution(arr1, 20));
            Console.WriteLine(BadSolution(arr2, 20));
            Console.WriteLine(BadSolution(arr3, 20));
            Console.WriteLine(BadSolution(arr4, 20));
            Console.WriteLine(BadSolution(arr5, 20));

            Console.WriteLine(GoodSolution(arr1, 20));
            Console.WriteLine(GoodSolution(arr2, 20));
            Console.WriteLine(GoodSolution(arr3, 20));
            Console.WriteLine(GoodSolution(arr4, 20));
            Console.WriteLine(GoodSolution(arr5, 20));
        }
        static char[] Reverse(char[] array)
        {
            int left = 0, right = array.Length - 1;

            while (left < right)
            {
                char tmp = array[left];
                array[left] = array[right];
                array[right] = tmp;
                left++;
                right--;
            }
            return array;
        }



        static int BadSolution(int[] array, int target)
        {
            int ans = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int j = i;
                int sum = 0;
                while (j < array.Length && sum + array[j] <= target)//n,n-1,n-2,...1
                {
                    sum += array[j++];

                }
                ans = Math.Max(ans, j - i);
            }

            return ans;
        }
            //for (int left = 0, right = array.Length - 1; left < right; left++, right--)
            //    (array[left], array[right]) = (array[right], array[left]);

            static int GoodSolution(int[] array, int target)
            {
                int ans = 0;
                int left = 0;
                int right = 0;
                int current = 0;
                while (right < array.Length)
                {
                    current += array[right++];
                    while (current > target)
                    {
                        current -= array[left++];

                        ans = Math.Max(ans, right - left);
                    }
                }
                return ans; //letcode.com
            }
        
    }
}


