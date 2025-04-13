using System;
using System.ComponentModel.DataAnnotations;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phone = new Dictionary<string, int>();
            phone.Add("samsung", 1);
            phone.Add("iPhone", 2);
            phone.Add("OPPO", 3);

            string keyCheck = "samsung";
            if (phone.ContainsKey(keyCheck))
            {
                Console.WriteLine($"key: {keyCheck} value:{phone[keyCheck]}");
            }
            else
                Console.WriteLine($"key: {keyCheck} not found");


            //удаление элемента
            string keyRemove = "OPPO";
            if (phone.Remove(keyRemove))
                Console.WriteLine($"key{keyRemove}");

            //проверка количества элементов после удаления
            Console.WriteLine($"Count: {phone.Count}");

        }

        
        
    }
}




       