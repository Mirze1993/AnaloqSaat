using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaloqSaat
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();

        Bitmap bitmap;
        int weght = 3000, height = 3000, sHand = 1400, mHand = 1100, hHand = 800;

        int cx, cy;

        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(weght+1, height+1);

            cx = weght / 2;cy = height / 2;

            this.BackColor = Color.AliceBlue;

            t.Interval = 1000;

            //t.Tick += new EventHandler(this.Tick);
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bitmap);

            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;
            
            label1.Text=hh+" : "+mm+" : "+ss;

            int[] kor = new int[2];

            g.Clear(Color.Coral);

            g.DrawEllipse(new Pen(Color.Black, 20f), 0, 0, weght, height);

            g.DrawString("12", new Font("Arial", 120), Brushes.Black, new PointF(1400, 20));
            g.DrawString("3", new Font("Arial", 120), Brushes.Black, new PointF(2860, 1400));
            g.DrawString("6", new Font("Arial", 120), Brushes.Black, new PointF(1420, 2820));
            g.DrawString("9", new Font("Arial", 120), Brushes.Black, new PointF(0, 1400));

            kor = msCort(ss, sHand);
            g.DrawLine(new Pen(Brushes.Red, 3f), new Point(cx, cy), new Point(kor[0], kor[1]));

            kor = msCort(mm, mHand);
            g.DrawLine(new Pen(Brushes.Black, 7f), new Point(cx, cy), new Point(kor[0], kor[1]));

            kor = hrCort(hh, mm, hHand);
            g.DrawLine(new Pen(Brushes.Black, 10f), new Point(cx, cy), new Point(kor[0], kor[1]));

            picBox.Image = bitmap;
            g.Dispose();

        }

       

        private int[] msCort(int valu, int hlen)
        {
            int[] kor = new int[2];
            valu *= 6;
            if (valu >= 0 && valu<= 180)
            {
                kor[0] = cx + (int)(hlen * Math.Sin(Math.PI * valu / 180));
                kor[1] = cy - (int)(hlen * Math.Cos(Math.PI * valu / 180));
            }
            else
            {
                kor[0] = cx - (int)(hlen * -Math.Sin(Math.PI * valu / 180));
                kor[1] = cy - (int)(hlen * Math.Cos(Math.PI * valu / 180));
            }
            return kor;
        }

        private int[] hrCort(int hv,int mv, int hlen)
        {
            int[] kor = new int[2];
            int valu =(int)(((hv%12)*15)+(mv*0.5));
            if (valu >= 0 && valu <= 180)
            {
                kor[0] = cx + (int)(hlen * Math.Sin(Math.PI * valu / 180));
                kor[1] = cy - (int)(hlen * Math.Cos(Math.PI * valu / 180));
            }
            else
            {
                kor[0] = cx - (int)(hlen * -Math.Sin(Math.PI * valu / 180));
                kor[1] = cy - (int)(hlen * Math.Cos(Math.PI * valu / 180));
            }
            return kor;
        }
    }
}
