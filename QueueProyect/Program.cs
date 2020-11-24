using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTSLib;

namespace QueueProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayQueue<int> stack = new ArrayQueue<int>(6);
            Console.WriteLine(stack);
            stack.Enqueue(1);
            Console.WriteLine(stack);
            stack.Enqueue(2);
            Console.WriteLine(stack);
            Console.WriteLine(stack.Head);
            Console.WriteLine(stack.Tail);
            stack.Enqueue(3);
            Console.WriteLine(stack);
            Console.WriteLine("El tamaño del arreglo: "+ stack.Size);
            Console.WriteLine(stack.Head);
            stack.Dequeue();
            Console.WriteLine(stack);
            Console.WriteLine(stack.Dequeue());
            Console.WriteLine(stack);
            Console.WriteLine(stack.IsEmpty());

        }
    }
}
