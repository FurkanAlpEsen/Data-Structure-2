using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2Beta1
{
    public interface IBodrum
    {
        void Push(Araba item);
        Araba Pop();
        Araba Peek();
        bool IsEmpty();
        int Top { get; set; }
    }
}
