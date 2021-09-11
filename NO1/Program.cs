//第二章第一题
using System;

namespace NO1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("请输入数字：");
            int number =int.Parse(Console.ReadLine());
            Console.WriteLine("所有质因数为：");
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                    Console.Write(i + " ");

                while (number % i == 0)
                    number /= i;
                
                    
            }
        }
    }
}
