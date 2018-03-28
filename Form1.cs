using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev2Beta1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] Renkler = {  "Siyah", "Bordo", "Sarı" ,"Mavi" };
        IlkKat Ik = new IlkKat(15);
        BodrumKat Bk = new BodrumKat(15);
        IkinciKat ik= new IkinciKat();
         Random r = new Random();
        Araba temp;
        Node tmp;
        int y = 0;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (y == 0)
                for (int i = 1; i <= 45; i++)
                {
                    Araba a = new Araba();
                    a.AracNo = i;
                    a.Renk = Renkler[r.Next(0, 4)];
                    if (i < 16)
                        Bk.Push(a);
                    else if (i < 31 && i >= 16)
                        Ik.Insert(a);
                    else
                        ik.Insert(a);
                }
            y++;

            ZeminList.Items.Clear();
            İlkKatList.Items.Clear();
            İkinciKatList.Items.Clear();

            foreach (Araba item in Bk.Bodrum)
            {
                if (item != null)
                    ZeminList.Items.Add(item.AracNo+ "  nolu  " + item.Renk+ "  renkli araç");
                else
                    continue;
            }
            foreach (Araba item in Ik.Ilk)
            {
                if (item != null)
                    İlkKatList.Items.Add(item.AracNo + "  nolu  " + item.Renk + "  renkli araç");
                else
                    continue;
            }
            for (int i = 0; i < ik.Size; i++)
            {
                Node t = ik.GetElement(i);
                if (t.Data != null)
                {
                    İkinciKatList.Items.Add(t.Data.AracNo + "  nolu  " + t.Data.Renk+ "  renkli araç");
                }
                else
                    break;
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (Ik.counter == 0)
            {
                return;
            }
            temp = Ik.Remove();

            MessageBox.Show( temp.AracNo + "  nolu arac  " + temp.Renk+ "  cıktı");

            int z = r.Next(1, 3);
            if (ik.Size == 0 && Bk.Top != -1)
            {
                z = 1;
            }
            else if (ik.Size != 0 && Bk.Top == -1)
            {
                z = 2;
            }
            else if (ik.Size == 0 && Bk.Top == -1)
                return;
            switch (z)
            {
                case 1:
                    temp = Bk.Pop();
                    Ik.Insert(temp);
                    MessageBox.Show( temp.AracNo+ "  nolu arac  " + temp.Renk+ "  cıktı");
                    break;
                case 2:
                    tmp = ik.Delete();
                    ik.Insert(tmp.Data);
                    MessageBox.Show( tmp.Data.AracNo + "  nolu arac  " + tmp.Data.Renk+ "  cıktı");

                    break;
            }
            y = 0;
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            DateTime dtBas = DateTime.Now;
            for (int i = 0; i < 45; i++)
            {

                if (Ik.counter == 0)
                {
                    return;
                }
                temp = Ik.Remove();

                MessageBox.Show( temp.AracNo+ "  nolu arac  " + temp.Renk + "  cıktı");

                int t = r.Next(1, 3);
                if (ik.Size == 0 && Bk.Top != -1)
                {
                    t = 1;
                }
                else if (ik.Size != 0 && Bk.Top == -1)
                {
                    t = 2;
                }
                else if (ik.Size == 0 && Bk.Top == -1)
                    continue; ;
                switch (t)
                {
                    case 1:
                        temp = Bk.Pop();
                        Ik.Insert(temp);
                        MessageBox.Show (temp.AracNo+ "  nolu arac  " + temp.Renk + "  cıktı");
                        break;
                    case 2:
                        tmp = ik.Delete();
                        Ik.Insert(tmp.Data);
                        MessageBox.Show( tmp.Data.AracNo+ "  nolu arac  " + tmp.Data.Renk+ "  cıktı");

                        break;
                }
            }
            y = 0;
            TimeSpan ts = DateTime.Now.Subtract(dtBas);
            MessageBox.Show("45 aracın çıkışında geçen süre: " + ts.ToString());
        }

        private void btnSureYaz_Click(object sender, EventArgs e)
        {

        }
    }
}
