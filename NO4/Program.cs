//第二章第四题
using System;

namespace NO4
{
    class Program
    {
        static bool IsToeplitz(float[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                if (arr[i, i] != arr[i + 1, i + 1])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            float[,] arr = { { 1, 2, 3, 4 }, { 2, 1, 3, 4 }, { 3, 4, 1, 2 } };
            Console.WriteLine(Program.IsToeplitz(arr));
        }
    }
}
