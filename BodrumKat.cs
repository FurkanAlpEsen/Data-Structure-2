using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2Beta1
{
    public class BodrumKat : IBodrum
    {
        public Araba[] Bodrum;
        private int top = -1;

        public BodrumKat(int size)
        {
            this.Bodrum = new Araba[size];
        }
        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }
        public void Push(Araba a)
        {
            if (Bodrum.Length == Top + 1)
            {
                throw new Exception("Hata: Stack dolu...");
            }
            Bodrum[++Top]= a ;
        }
        public Araba Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Hata: Stack Boş");
            }
            Araba temp = Bodrum[Top--];
            return temp;
        }
        public object Peek()
        {
            return Bodrum[Top];
        }
        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        Araba IBodrum.Pop()
        {
            throw new NotImplementedException();
        }

        Araba IBodrum.Peek()
        {
            throw new NotImplementedException();
        }
    }
}
