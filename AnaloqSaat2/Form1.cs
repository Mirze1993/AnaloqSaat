using AnaloqSaat2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaloqSaat2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap  bHour,  bminut, bsecond;
        List<Image> ımages = new List<Image>
        {
            Resources.clock1,
            Resources.clock2,
            Resources.clock3,
            Resources.clock4,
            Resources.clock5,
            Resources.clock6,
        };
        int next = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            pBack.Image = ımages[next];

            bHour = new Bitmap(Resources.hour);
            bminut = new Bitmap(Resources.minut);
            bsecond = new Bitmap(Resources.second);
            timer.Start();
        }

        private Bitmap RotateImage(Bitmap bitmap, float angle)
        {
            Bitmap rotated = new Bitmap(bitmap.Width, bitmap.Height);

            using (Graphics g = Graphics.FromImage(rotated))
            {
                g.TranslateTransform((float)bitmap.Width / 2, (float)bitmap.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-(float)bitmap.Width / 2, -(float)bitmap.Height / 2);
                //sekili cekmek
                g.DrawImage(bitmap, new Point(0, 0));
            }
            return rotated;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            label1.Text = DateTime.Now.ToString("HH:mm");
            label2.Text = DateTime.Now.ToString("ss");
            label3.Text = DateTime.Now.ToString("dd/MM/yyyy");

            pBack.Controls.Add(pHour);
            pHour.Location = new Point(0, 0);
            pHour.Image = RotateImage(bHour, (float)((hh % 12) * 30 + mm * 0.5));

            pHour.Controls.Add(pMinut);
            pMinut.Location = new Point(0, 0);
            pMinut.Image = RotateImage(bminut, mm *= 6);

            pMinut.Controls.Add(pSecond);
            pSecond.Location = new Point(0, 0);
            pSecond.Image = RotateImage(bsecond, ss *= 6);

            pSecond.Controls.Add(pDot);
            pDot.Location = new Point(0, 0);
            pDot.Image = Resources.dot;

        }



        private void bIreli_Click(object sender, EventArgs e)
        {
            next++;
            if (next > 5) next = 0;
            pBack.Image = ımages[next];
        }
        private void bArxa_Click(object sender, EventArgs e)
        {
            next--;
            if (next < 0) next = 5;
            pBack.Image = ımages[next];
        }
    }
}
