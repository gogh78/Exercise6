using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение.
            //Предложение представляет собой слова, разделенные пробелом.
            //Знаки препинания не используются. Составить программу,
            //определяющую является ли строка палиндромом без учёта пробелов и регистра
            //(пример палиндрома – «А роза упала на лапу Азора»).
            Console.WriteLine("Введите предложение ");
            string startString = Console.ReadLine();
            startString = startString.Replace(" ", string.Empty);
            string reverseString = "";
            for (int i = startString.Length - 1; i >= 0; i--)
            {
                reverseString += startString[i]; // переворачиваем строку
            }
            if (startString == reverseString)
                Console.WriteLine("Введенное предложение является палиндромом");
            else
                Console.WriteLine("Введенное предложение не является палиндромом");
            Console.ReadKey();
        }
    }
}