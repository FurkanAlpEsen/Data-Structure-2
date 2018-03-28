using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2Beta1
{
    public class IlkKat : I_IlkKat
    {
        public Araba[] Ilk;
        public int front = -1;
        public int rear = -1;
        public int size = 0;
        public int counter = 0;

        public IlkKat(int size)
        {
            this.size = size;
            Ilk = new Araba[size];
        }

        public void Insert(Araba a)
        {
            if (counter==size)
            {
                throw new Exception("İlk kat dolu...");
            }
            if (front == -1)
                front = 0;

            if (rear==15)
            {
                rear = 0;
            }
            Ilk[++rear] = a;
            counter++;                                                    //Arabalara sıra numarası ver..                    
        }

        public Araba Remove()
        {
            if (IsEmpty())
                throw new Exception("Otoparkta çıkarılacak araç yok..");//return "Otoparkta çıkarılacak araç yok.";

            Araba temp = Ilk[front];

            Ilk[front] = null;

            front++;
            if (front ==15)
                front = 0;

            counter--;
            return temp;
        }
        public bool IsEmpty()
        {
            return counter == 0;
        }

        public Araba Peek()
        {
            return Ilk[front];
        }

        public Araba Insert(object a)
        {
            throw new NotImplementedException();
        }
    }
}
