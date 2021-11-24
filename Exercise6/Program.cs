using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввести с клавиатуры предложение.
            // Предложение представляет собой слова, разделенные пробелом.
            // Знаки препинания не используются.
            // Найти самое длинное слово в строке.
            Console.WriteLine("Введите строку ");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            int max = 0;
            int n = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > max)
                {
                    max = stringArray[i].Length;
                    n = i;
                }
            }
            Console.WriteLine("Самое длинное слово в предложении - \"{0}\" состоит из {1} букв", stringArray[n], max);
            Console.ReadKey();

        }
    }
}