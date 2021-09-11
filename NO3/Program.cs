//第二章第三题
using System;
using System.Collections;
namespace NO3
{
    class Program
    {

        static void IsPrime(ArrayList arrayList)
        {

            for (int i = 2; i <= 100; i++)
            {

                for (int j = 0; j < arrayList.Count; j++)
                {
                    if ((int)arrayList[j] % i == 0 && (int)arrayList[j] / i != 1)
                        arrayList.Remove(arrayList[j]);
                }

            }
            Console.WriteLine("2-100中质数：");
            foreach (object n in arrayList)
            {
                Console.Write(n + " ");
            }
        }
        static void Main(string[] args)
        {
            ArrayList primeNumber = new ArrayList();
            for (int i = 2; i <= 100; i++)
            {
                primeNumber.Add(i);
            }
            Program.IsPrime(primeNumber);


        }
    }
}
