using System;
using System.Collections.Generic;
namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, -4, 5, 5, 10, 0, 7 };
            int[] answer = SumOfTwo(arr, 6);
            if (answer != null)
                Console.WriteLine(answer[0] + " " + answer[1]);
            else Console.WriteLine("Таких нет!");

            if (TryGetFirstDuplicate(" a sfd", out char ch))
                Console.WriteLine($"Первый символб который встречается дважды'{ch}'");
            else Console.WriteLine("Все символы уникальны " + ch);
                
            Console.WriteLine("Result:" + Help("abbaccababcd", 2));
            

                //1) Сумма 2 учитывая массив целых чисел nums и целое число target, верните индексы двух чисел
                //сумма которых равна target.Нельзя использовать один и тот же индекс дважды.
                static int[] SumOfTwo(int[] nums, int target)
                {
                if (nums == null) return null;
                //ключ - значение элемента
                //значение - индекс
                Dictionary<int, int> pairs = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int key = target - nums[i];
                    if (pairs.TryGetValue(key, out int value))
                        return new int[] { value, i };
                    if (!pairs.ContainsKey(nums[i]))
                        pairs.Add(nums[i], i);
                }

                return null;
                }
                    //2) Первая буква должна появиться дважды. Учитывая строку s,
                    //верните первый символ,который встречается дважды.
                    static bool TryGetFirstDuplicate(string s, out char value)
                    {
                        value = '\0';
                        if (String.IsNullOrEmpty(s)) return false;

                        HashSet<char> characters = new HashSet<char>();
                        foreach (char ch in s)
                        {
                            if (characters.Contains(ch))
                            {
                                value = ch;
                                return true;
                            }
                            characters.Add(ch);
                        }
                        return false;
                    }
           //3) Дана строка s и целое число k. Найти длину самой длинной подстроки,
           //содержащей не более k разных символов. Например, если даны s="eceba"
           //и k=2, верните 3.Самая длинная подстрока, содержаща не более 3 разных символов, - "ece".
            static int Help(string s,int k)
            {
                if (String.IsNullOrEmpty(s)|| k<=0) return -1;

                if (s.Length < k) return s.Length;

                Dictionary<char, int> pairs = new Dictionary<char, int>();
                int left = 0, right = 0, max = 0;
                for (; right < s.Length; right++)
                {
                    char rightKey = s[right];
                    if (pairs.ContainsKey(rightKey))pairs[rightKey]++;
                    else 
                    { 
                        pairs[rightKey] = 1;
                        max = Math.Max(max, right - left);
                    }

                    for (; pairs.Count > k; left++)
                    {
                        char leftKey = s[left];
                        pairs[leftKey]--;
                        if (pairs[leftKey]]== 0)
                            pairs.Remove(leftKey);
                    }
                    
                }
                return max;
            }
                
        }
    }
}
