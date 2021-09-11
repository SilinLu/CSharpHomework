//第二章第二题
using System;

namespace NO2
{
    class Program
    {


        static void Main(string[] args)
        {
            int maxNum = int.MinValue, minNum = int.MaxValue, avgNum = 0, sum = 0;
            int[] arr = { 432, 32, 1, 34, 6, 12, -11, 23, -33, 322, 144, 78, 4 };
            foreach (int i in arr)
            {
                if (i > maxNum)
                    maxNum = i;
                if (i < minNum)
                    minNum = i;
                sum += i;
            }
            avgNum = sum / arr.Length;
            Console.WriteLine($"最大值：{maxNum}，最小值：{minNum}，平均值：{avgNum}，所有元素求和：{sum}");
        }
    }
}
