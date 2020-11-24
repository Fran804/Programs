using DTSLib;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProyect
{
    class Program
    {

        static void Main(string[] args)
        {
            ArrayStack<int> stack = new ArrayStack<int>(6);
            Console.WriteLine(stack);

            stack.Push(3);
            Console.WriteLine(stack);

            stack.Push(-2);
            stack.Push(7);
            Console.WriteLine(stack);

            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack);

            //stack.Push(new int[] { 32, 1, 8, -4 });
            stack.Push(32, 1, 8, -4);
            Console.WriteLine(stack);

            stack.Push(90);
            Console.WriteLine(stack);


            int num1 = stack.Pop();
            stack.Push(num1);
            stack.Push(num1);
            Console.WriteLine(stack);

            int largoStack = stack.Size;
            for (int i = 0; i < largoStack; i++)
            {
                stack.Pop();
            }
            Console.WriteLine(stack);

        }
    }
}
