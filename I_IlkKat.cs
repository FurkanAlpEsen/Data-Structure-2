using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2Beta1
{
    public interface I_IlkKat
    {
        void Insert(Araba a);
        Araba Remove();
        Araba Peek();
        Boolean IsEmpty();
    }
}
