//第一章第一题
using System;

namespace NO5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b;

            Console.WriteLine("输入第1个数字：");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("输入第2个数字：");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("输入运算符：");
            char c = char.Parse(Console.ReadLine());
            switch (c)
            {
                case '+': Console.WriteLine($"{a}+{b}={a + b}"); break;
                case '-': Console.WriteLine($"{a}-{b}={a - b}"); break;
                case '*': Console.WriteLine($"{a}*{b}={a * b}"); break;
                case '/': Console.WriteLine($"{a}/{b}={a / b}"); break;
                default: Console.WriteLine("输入错误"); break;
            }

        }
    }
}

