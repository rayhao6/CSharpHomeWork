using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{

    // 链表节点
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

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T>action)
        {
            for(Node<T>x= head;x!=null;x = x.Next)
            {
                action(x.Data);
            }
        }

    }

    class list
    {

        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            //for (Node<int> node = intlist.Head;
            //      node != null; node = node.Next)
            //{
            //    Console.WriteLine(node.Data);
            //}
            int max=0, min=999999999, sum=0;
            intlist.ForEach(x => Console.WriteLine(x));
            intlist.ForEach (x => sum += x);
            intlist.ForEach(x => { if (x > max) max = x; });
            intlist.ForEach(x => { if (x < min) min = x; });
            Console.Write(sum);
            Console.Write(max);
            Console.Write(min);
            // 字符串型List
            GenericList<string> strList = new GenericList<string>();
            //for (int x = 0; x < 10; x++)
            //{
            //    strList.Add("str" + x);
            //}
            //for (Node<string> node = strList.Head;
            //        node != null; node = node.Next)
            //{
            //    Console.WriteLine(node.Data);
            //}


        }

    }
}