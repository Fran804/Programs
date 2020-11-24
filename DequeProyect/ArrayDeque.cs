using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTSLib
{
    class ArrayDeque<e> : IDeque<e>
    {
        private e[] data;

        public ArrayDeque(int capacity)
        {
            data = new e[capacity];
            Size = 0;
        }
        public int Size { get; private set; }

        public e Back 
        { 
            get
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("empty stack");
                }
                return data[Size - 1];
            } 
        }

        public e Front
        {
            get
            {
                return data.First<e>();
            }
        }

        public bool IsEmpty() => Size == 0;

        public e PopBack() //eliminar el ultimo elemento y retornar el array O eliminar el elemento y retornar el elemento en pantalla
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("empty stack");
            }

            return data[--Size];
        }

        public e PopFront()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("empty stack");
            }
            e[] auxData = new e[data.Length];
            auxData[Size - 1] = data[0];
            for (int i = 1; i < Size; i++) //2
            {
                auxData[i - 1] = data[i];
            }
            data = auxData;
            return data[--Size];
        }

        public void PushBack(e element) //Inserta un nuevo elemento e al final del deque.
        {
            data[Size++] = element;            
        }

        public void PushFront(e element)
        {            
            e[] auxData = new e[data.Length];            
            auxData[0] = element;
            for (int i = 1; i < auxData.Length; i++)
            {
                auxData[i] = data[i - 1];
            }
            data[Size++] = auxData[Size - 1];
            data = auxData;            
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
