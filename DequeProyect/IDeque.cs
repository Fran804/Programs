using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTSLib
{
    interface IDeque<e>
    {
        void PushBack(e element);
        void PushFront(e element);
        e PopBack();
        e PopFront();
        e Back { get; }
        e Front { get; }
        int Size { get; }
        bool IsEmpty();
    }
}
