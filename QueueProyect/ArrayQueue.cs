using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTSLib
{
    class ArrayQueue<e> : IQueue<e>
    {
        private e[] data;
        public int Size { get; private set; } // retorna el numero de elementos en el queue
        public ArrayQueue(int capacity)
        {
            data = new e[capacity];
            Size = 0;
        }

        public e Head 
        {
            get
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("empty stack");
                }
                return data.First<e>();
            }
        }

        public e Tail
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

        public e Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("empty stack");
            }
            e[] auxData = new e[data.Length];
            auxData[Size - 1] = data[0];
            for (int i = 1; i < Size; i++)
            {
                auxData[i - 1] = data[i];
            }
            data = auxData;
            return data[--Size];
        }

        public void Enqueue(e element) //Agrega el elemento e al final del queue
        {           
            data[Size++] = element;
        }

        public bool IsEmpty() => Size == 0; //Retorna un booleano indicado si el queue esta vacio

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
