//第四讲第一题
using System;

namespace NO7
{

    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head { get => head; 
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
                head = tail = n;
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public static void ForEach(GenericList<T> genericList, Action<T> action)
        {
            Node<T> node=genericList.Head;
            while (node != null)
            {
                action(node.Data);
                node = node.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> genericList = new GenericList<int>();
            genericList.Add(1);
            genericList.Add(2);
            genericList.Add(3);
            GenericList<int>.ForEach(genericList,m=>Console.WriteLine(m));
            int sum=0;
            GenericList<int>.ForEach(genericList, m => sum+=m);
            Console.WriteLine("sum:" + sum);
            int max = int.MinValue;
            GenericList<int>.ForEach(genericList, (m) => {
                if (m > max)
                    max = m;
            });
            Console.WriteLine("max:" + max);

            int min = int.MaxValue;
            GenericList<int>.ForEach(genericList, (m) => {
                if (m <min)
                    min = m;
            });
            Console.WriteLine("min:" + min);
        }
    }
}
