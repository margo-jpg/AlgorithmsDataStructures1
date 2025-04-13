using System;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tmp = rnd.Next(1, 100);
            Console.WriteLine(tmp);
            int[] arr1 = new int[] { -5, -2, 3, 10, 12 };
            int[] ress = Solution3(arr1, 10);
            if (ress.Length == 0)
                Console.WriteLine("Таких нет");
            foreach (var elem in ress)
                Console.WriteLine(elem + " ");
            Console.WriteLine();

            int[] arr3 = new int[] { 1, 0, 0, 3, 1, 3, 2, 4, 3 };
            Console.WriteLine(Solution4(arr3, 7));
        }

        static int Solution4(int[] arr, int target)
        {
            int min = 0;
            int sum = 0;
            int left = 0, right = 0;
            for(; right < arr.Length;)
            {
                if(sum < target)
                {
                    sum += arr[right];
                    right++;
                }
                while(left < arr.Length && sum >= target)
                {
                    sum -= arr[left++];
                }
                if (min == 0 || min > right - left + 1) min = right-left+1;
            }

            return min;
        }

        static int[] Solution3(int[] arr, int target)
        {
            int[] res = new int[2];
            int left = 0, right = arr.Length - 1;
            for (; left < right;)
            {
                if (arr[left] + arr[right] == target)
                {
                    res[0] = arr[left];
                    res[1] = arr[right];
                    break;
                }
                if (arr[left] + arr[right] > target)
                    right++;
                else left++;
            }
            if (left >= right)
                res = new int[0];

            return res;
        }
    }
}


