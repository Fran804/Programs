using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTSLib
{
    interface IQueue<e>
    {
        int Size { get; }
        e Head { get; } 
        e Tail { get; } 
        void Enqueue(e element);
        e Dequeue();
        bool IsEmpty();
    }
}
