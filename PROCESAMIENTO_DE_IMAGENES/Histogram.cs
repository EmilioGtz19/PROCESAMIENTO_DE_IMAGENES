using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROCESAMIENTO_DE_IMAGENES
{
    public partial class Histogram : Form
    {
        private int[] R;
        private int[] G;
        private int[] B;
        private int Rhigh;
        private int Ghigh;
        private int Bhigh;


        public Histogram(int[] rHistogram, int[] gHistogram, int[] bHistogram)
        {
            InitializeComponent();

            R = rHistogram;
            G = gHistogram;
            B = bHistogram;
            int n;

            Rhigh = 0;
            for (n = 0; n < 256; n++)
            {
                if (R[n] > Rhigh)
                {
                    Rhigh = R[n];
                }
            }

            for (n = 0; n < 256; n++)
            {
                R[n] = (int)((float)R[n] / (float)Rhigh * 256.0f);
            }

            Ghigh = 0;
            for (n = 0; n < 256; n++)
            {
                if (G[n] > Ghigh)
                {
                    Ghigh = G[n];
                }
            }

            for (n = 0; n < 256; n++)
            {
                G[n] = (int)((float)G[n] / (float)Ghigh * 256.0f);
            }

            Bhigh = 0;
            for (n = 0; n < 256; n++)
            {
                if (B[n] > Bhigh)
                {
                    Bhigh = B[n];
                }
            }

            for (n = 0; n < 256; n++)
            {
                B[n] = (int)((float)B[n] / (float)Bhigh * 256.0f);
            }
        }

        private void Histogram_Paint(object sender, PaintEventArgs e)
        {
            int n = 20;
            Graphics g = e.Graphics;
            Pen Rpen = new Pen(Color.Red);
            Pen Gpen = new Pen(Color.Green);
            Pen Bpen = new Pen(Color.Blue);
            Pen axes = new Pen(Color.Black);

            g.DrawLine(axes, 19, 271, 277, 271);
            g.DrawLine(axes, 19, 270, 19, 14);

            for(n = 0; n < 256; n++)
            {
                g.DrawLine(Rpen, n + 20, 270, n + 20, 270 - R[n]);
            }
            for (n = 0; n < 256; n++)
            {
                g.DrawLine(Gpen, n + 20, 270, n + 20, 270 - G[n]);
            }
            for (n = 0; n < 256; n++)
            {
                g.DrawLine(Bpen, n + 20, 270, n + 20, 270 - B[n]);
            }
        }
    }
}
