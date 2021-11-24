using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string Change(string s)
        {
            int firstOpen = s.IndexOf('{'); /// Индекс первой открывающей скобки
            int firstClose = s.IndexOf('}'); /// Индекс первой закрывающей скобки

            if (firstOpen < 0 && firstClose < 0) /// В выражении нет скобок
                return s;

            if (firstOpen < 0 && firstClose >= 0)
                throw new ArgumentException("В выражении есть открывающая скобка, но нет закрывающей");

            if (firstClose < 0)
                throw new ArgumentException("В выражении есть закрывающая скобка, но нет открывающей");

            if (firstOpen > firstClose)
                throw new ArgumentException("В выражении закрывающая скобка раньше открывающей");

            int lastOpen = s.LastIndexOf('{', firstClose); /// Индекс последней открывающей скобки
                                                           /// находящейся перед первой закрывающей

            if (firstOpen != lastOpen)
                throw new ArgumentException("В выражении есть вложенные скобки");

            s = s.Substring(0, firstOpen) + s.Substring(firstClose + 1); /// Удаление скобок и символов между ними

            return Change(s); /// Рекурсивный вызов для удаления следующей пары скобок
        }
        static void Main(string[] args)
        {
            System.Console.Write("s = ");
            String s = System.Console.ReadLine();
            System.Console.WriteLine("new string =|" + Change(s) + "|");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
