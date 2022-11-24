using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROCESAMIENTO_DE_IMAGENES
{
    public partial class frmEditImage : Form
    {

        private Bitmap bmp;
        private Form activeForm = null;

        private int[] R = new int[256];
        private int[] G = new int[256];
        private int[] B = new int[256];

        public frmEditImage()
        {
            InitializeComponent();          
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenImage = new OpenFileDialog
            {
                Filter = "Image files (*.png)|*.png|(*.bmp)|*.bmp|(*.jpeg)|*.jpeg|(*.jpg)|*.jpg"
            };

            if (OpenImage.ShowDialog() == DialogResult.OK)
            {
                picBox.Image = new Bitmap(OpenImage.FileName);
                bmp = new Bitmap(picBox.Image);
            }
              
            OpenImage.Dispose();

        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            /*
            DialogResult dialogResult = MessageBox.Show("Sure", "Limpiar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            */
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            /*
            if (picBox.Image != null)
            {
                SaveFileDialog Guardar = new SaveFileDialog();
                Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
                Image Imagen = picBox.Image;
                Guardar.ShowDialog();

                Imagen.Save(Guardar.FileName);
            }
            else
            {
                MessageBox.Show("Ninguna imagen cargada", "Guardar Imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void BtnGrayscale_Click(object sender, EventArgs e)
        {
            /*
            if(bmp != null)
            {
                for (int j = 0; j < bmp.Width; j++)
                    for (int i = 0; i < bmp.Height; i++)
                    {
                        bmp.SetPixel(j, i, Color.FromArgb(120, 200, 120));
                    }

                picBox.Image = bmp;
            }
            */
        }

        private void BtnHistogram_Click(object sender, EventArgs e)
        {

            if (bmp != null)
            {
                Color color;

                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        color = bmp.GetPixel(x, y);

                        R[color.R]++;
                        G[color.G]++;
                        B[color.B]++;

                    }
                }

                if (activeForm != null)
                {
                    activeForm.Close();
                    activeForm.Dispose();
                }
                activeForm = new Histogram(R, G, B)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                panelHistogram.Controls.Add(activeForm);
                activeForm.Show();
            }

        }
    }
}
