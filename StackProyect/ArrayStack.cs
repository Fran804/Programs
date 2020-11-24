using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTSLib
{
    class ArrayStack<T> : IStack<T>
    {
        private T[] data;
        private int minCapacity;

        public int Size { get; private set; }

        public ArrayStack(int capacity)
        {
            data = new T[capacity];
            minCapacity = capacity;
            Size = 0;
        }

        public bool IsEmpty() => Size == 0;

        public void Push(T element)
        {
            if (Size == data.Length)
            {
                T[] auxData = new T[data.Length * 2]; //crecer x2
                Array.Copy(data,auxData, data.Length);
                data = auxData;
            }

            data[Size++] = element;
        }

        public void Push(params T[] elements)
        {
            foreach (T e in elements)
            {
                Push(e);
                //data[Size++] = e;
            }
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("empty stack");
            }
            if (((Size-1) <= data.Length/10) && ((data.Length/2)>= minCapacity))
            {
                Array.Resize(ref data, data.Length / 2);
            }

            return data[--Size];
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("empty stack");
            }

            return data[Size - 1];
        }

        public override string ToString()
        {
            string debug = $"[C:{data.Length} S:{Size} Empty:{IsEmpty()}]";

            debug += " { ";
            for (int i = 0; i < Size; ++i)
            {
                debug += $"{data[i]} ";
            }
            debug += "}";

            return debug;
        }
    }
}