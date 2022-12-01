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
        private int bmpWidth;
        private int bmpHeight;
      

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
                bmpWidth = bmp.Width;
                bmpHeight = bmp.Height;
            }
              
            OpenImage.Dispose();
            GenerateHistogram();

        }

        private void BtnClean_Click(object sender, EventArgs e)
        {

            if (picBox.Image != null)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de borrar tu progreso?", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    picBox.Image.Dispose();
                    picBox.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Ninguna imagen cargada", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            
            if (picBox.Image != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
                Image Imagen = picBox.Image;
                
                if(save.ShowDialog() == DialogResult.OK)
                {
                    Imagen.Save(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Ninguna imagen cargada", "Guardar Imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnGrayscale_Click(object sender, EventArgs e)
        {
            
            if(bmp != null)
            {
                Color actualColor, newColor;
                Bitmap finalColor = new Bitmap(bmpWidth, bmpHeight);

                for (int j = 0; j < bmpWidth; j++)
                    for (int i = 0; i < bmpHeight; i++)
                    {
                        actualColor = bmp.GetPixel(j, i);
                        newColor = Color.FromArgb(actualColor.R, actualColor.R, actualColor.R);
                        finalColor.SetPixel(j, i, newColor);
                    }

                picBox.Image = finalColor;
                bmp = finalColor;
                GenerateHistogram();
            }
            
        }

        private void GenerateHistogram()
        {
            if (bmp != null)
            {
                Color color;

                for (int x = 0; x < bmpWidth; x++)
                {
                    for (int y = 0; y < bmpHeight; y++)
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

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if(bmp != null)
            {
                Color actualColor, newColor;
                Bitmap finalColor = new Bitmap(bmpWidth, bmpHeight);

                for (int j = 0; j <bmpWidth;j++)
                    for(int i = 0; i< bmpHeight; i++)
                    {
                        actualColor = bmp.GetPixel(j, i);
                        newColor = Color.FromArgb(255 - actualColor.R, 255 - actualColor.G, 255 - actualColor.B);
                        finalColor.SetPixel(j, i, newColor);

                    }

                picBox.Image = finalColor;
                bmp = finalColor;
                GenerateHistogram();
            }
        }
    }
}
