using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTSLib;

namespace DequeProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayDeque<int> stack = new ArrayDeque<int>(6);
            Console.WriteLine(stack);
            stack.PushBack(2);
            stack.PushBack(3);
            stack.PushBack(10);
            Console.WriteLine(stack);
            Console.WriteLine(stack.Back);
            Console.WriteLine(stack.Front);
            Console.WriteLine(stack.Size);
            stack.PopBack();
            stack.PushFront(1);
            stack.PushFront(4);
            Console.WriteLine(stack);          
            Console.WriteLine(stack.PopFront());
            Console.WriteLine(stack);
            stack.PopBack();
            Console.WriteLine(stack);
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
