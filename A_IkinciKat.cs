using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2Beta1
{
    public abstract class A_IkinciKat
    {
        public Node Head;
        public int Size = 0;
        public abstract void Insert(Araba value);
        public abstract Node Delete();
        public abstract Node GetElement(int position);
        public abstract string Yazdır();
    }
}
