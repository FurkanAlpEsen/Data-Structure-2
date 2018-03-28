using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2Beta1
{
    public class IkinciKat : A_IkinciKat
    {
        public override void Insert(Araba value)
        {
            Node tmpHead = new Node
            {
                Data = value
            };
            if (Head==null)
            {
                Head = tmpHead;
                Head.Next = Head;
            }
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;
        }
        public override Node Delete()
        {
            Node temp = Head;

            int n = Size, sayac=1 ;
            sayac = JosephUs(n);
            int x = (2 * (Size - sayac) + 1);

            if(x != 1)
            {
                for (int i = 0; i < x; i++)
                {
                    temp = temp.Next;
                }
                Size--;
            }
            else
            {
                if (Size != 1)
                {
                    while (temp.Next != Head)
                    {
                        temp = temp.Next;
                    }
                    Head = temp.Next;
                }
                Size--;
            }
            return temp;
        }
        public override Node GetElement(int post)
        {
            Node returnNode = null;
            Node temporaryNode = Head;
            int sayac = 0;

            while (Head != null)
            {
                if (sayac == post )
                {
                    returnNode = temporaryNode;                  
                }
                sayac++;
            }
            return returnNode;
        }
        public int JosephUs(int n)
        {
            int sayac = 1;
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    sayac *= 2;
                }
                else
                    n--;
            }
            return sayac;
        }
        public override string Yazdır()
        {
            string s = "";
            Node item = Head;

            while (item != null)
            {
                s += "---->" + item.Data;
                item = item.Next;
            }
            return s;
        }
    }
}
