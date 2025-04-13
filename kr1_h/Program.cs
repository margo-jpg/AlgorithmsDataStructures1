using System;
using System.Collections.Generic;
namespace kr1_h
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = { 3, 0, 1 };  //можно и так
            int[] test2 = new int[] { 9, 6, 4, 2, 3, 4, 5, 7, 0, 1 }; //можно так
            int[] test3 = new int[] { 0, 1 };
            Console.WriteLine(task1(test1)); //2
            Console.WriteLine(task1(test2)); //8
            Console.WriteLine(task1(new int[0])); //-1

            int[] test4 = { 5, 7, 3, 9, 4, 9, 8, 3, 1 };
            int[] test5 = { 9, 9, 2, 2 };
            int[] test6 = { 1, 1, int.MinValue };
            Console.WriteLine(task2(test4));
            Console.WriteLine(task2(test5));
            Console.WriteLine(task2(test6));

        }
       // 1
        public static int task1(int[] array)
         {
             if (array == null || array.Length == 0)
                 return -1; //входная ошибка
            // 0(n)сложнотсь 
             HashSet<int> set = new HashSet<int>(array);

             for (int i = 0; i <= array.Length; i++)
                 if (!set.Contains(i))
                     return i;
             return -1; //никогда не будет выполняться
         }
      //  2
        public static int? task2(int[] array) //int? помимо целых чисел может хранить null
        {
            if (array is null || array.Length == 0)
                return null;

            Dictionary<int, int> pairs = new Dictionary<int, int>();
            foreach (int elem in array)
            {
                if (!pairs.ContainsKey(elem))
                    pairs[elem] = 1;
                else
                    pairs[elem]++;
            }
            int max = int.MinValue;
            bool flag = false;


            foreach (var pair in pairs)
            {
                if (pair.Value == 1 && pair.Key > max)
                {
                    max = pair.Key;
                    flag = true;
                }
            }
            return flag ? max : null;
        }

    }
}