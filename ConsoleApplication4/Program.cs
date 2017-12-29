using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Test
    {
        private string test;
        public Test(string test)
        {
            this.test = test;
        }
        public override string ToString()
        {
            return "Test " + test;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<Array> Arr1 = new ArrayList<Array>();
            ArrayList<Array> Arr2 = new ArrayList<Array>();

            //Stack<Test> stack = new Stack<Test>();

            //stack.Push(new Test("n0"));
            //stack.Push(new Test("n1"));
            //stack.Push(new Test("n2"));
            //stack.Push(new Test("n3"));
            //stack.Push(new Test("n4"));

            //Console.WriteLine(stack.Pop());

            Queue<Test> queue = new Queue<Test>();
            //Console.WriteLine(queue.size());
            queue.Enqueue(new Test("n1"));
            queue.Enqueue(new Test("n2"));
            queue.Enqueue(new Test("n3"));

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.get(0));
            Console.WriteLine(queue.size());
            //Console.WriteLine(queue.Dequeue());


            //ArrayList<Test> array = new ArrayList<Test> { };

            //array.Add(new Test("13"));
            //array.Add(new Test("46"));
            //array.Add(new Test("10"));
            //array.Add(new Test("32"));
            //array.Add(new Test("5"));
            //array.Add(new Test("27"));

            //Console.WriteLine(array.get(3));
            //array.Remove(2);
            //Console.WriteLine(array.get(2));
            //Console.ReadKey();
        }
    }
}
