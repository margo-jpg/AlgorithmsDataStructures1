using System;

namespace kr_1
{ 
     class Program
    {
        static void Main(string[] args)
        { 
        Cheker checker = new Cheker(); 
        string Pangram = "qwertYuiOpAAAaSddfGghjJkkLZxccVBnM";
        string notPangram = "TYughhfa";
        Console.WriteLine($"'{Pangram}' это панграма? {checker.Pangram(Pangram)}");
        Console.WriteLine($"'{notPangram}' это панграма? {checker.Pangram(notPangram)}");
        }
    }
    public class Cheker
    {
        const string alphabet = "mnbvcxzlkjhgfdsapoiuytrewq";
        public bool Pangram(string inputString)
        {
            return alphabet.All(inputString.ToLower().Contains);
        }
    }
    // Используем метод All() из Linq для проверки, содержит ли строка inputString (в нижнем регистре) все буквы из алфавита.
    
    // alphabet.All возвращает true, если все буквы в алфавите содержатся в строке inputString.

    //class Program 
    //{
    //    static void Main(string[] args)
    //    {
    //        string Pangram = "qwertYuiOpAAAaSddfGghjJkkLZxccVBnM";
    //        bool res = Program.Checker(Pangram);
    //        Console.WriteLine($"Это панграма? {res}");//true

    //        string notPangram= "TYughhfa";
    //        bool res2 = Program.Checker(notPangram);
    //        Console.WriteLine($"Это панграма? {res2}");//false

    //    }
    //    static bool Checker(string input)
    //    {
    //        bool[] alphabet = new bool[26]; //массив для отслеживания найденых букв
    //        int index;
    //        //проход по каждому символу в строке
    //        foreach (char c in input.ToLower())
    //        {//проверка является ли символ буквой
    //            if (c >= 'a' && c <= 'z')
    //            {
    //                index = c - 'a';//ищем индекс буквы в алфавите
    //                alphabet[index] = true;  //отмечаем как найденую
    //            }
    //        }
    //        for (int i = 0; i < alphabet.Length; i++) //проверка найдены ли все буквы
    //        {
    //            if (!alphabet[i]) //если хоть одна не найдена то false
    //                return false;
    //        }

    //        return true; // если все буквы возвращены
    //    }
    // }

}
