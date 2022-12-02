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
        private Color actualColor;
        private Color newColor;


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
                    if (activeForm != null)
                    {
                        activeForm.Close();
                        activeForm.Dispose();
                    }
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

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {             
                Bitmap finalColor = new Bitmap(bmpWidth, bmpHeight);

                for (int j = 0; j < bmpWidth; j++)
                    for (int i = 0; i < bmpHeight; i++)
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

        private void BtnSepia_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                Bitmap finalColor = new Bitmap(bmpWidth, bmpHeight);

                for(int j = 0; j < bmpWidth; j++)
                    for(int i = 0; i < bmpHeight; i++)
                    {
                        actualColor = bmp.GetPixel(j,i);

                        int a = actualColor.A;
                        int r = actualColor.R;
                        int g = actualColor.G;
                        int b = actualColor.B;

                        int tempR = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                        int tempG = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                        int tempB = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                        if (tempR > 255) r = 255;
                        else r = tempR;
                        
                        if(tempG > 255) g = 255;
                        else g = tempG;
                        
                        if(tempB > 255) b = 255;                        
                        else b = tempB;
                        
                        finalColor.SetPixel(j, i, Color.FromArgb(a, r, g, b));
                    }

                picBox.Image = finalColor;
                bmp = finalColor;
                GenerateHistogram();
            }
        }

        private void BtnNoise_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                int percentage = 150;
                int minRange = 85;
                int maxRange = 115;
                float brightness;
                Random rand = new Random();
                int r, g, b;
                Bitmap finalColor = new Bitmap(bmpWidth, bmpHeight);

                for (int j = 0; j < bmpWidth; j++)
                    for (int i = 0; i < bmpHeight; i++)
                    {
                        if (rand.Next(1, 100) <= percentage)
                        {
                            brightness = rand.Next(minRange, maxRange) / 100.0f;
                            actualColor = bmp.GetPixel(j, i);

                            r = (int)(actualColor.R * brightness);
                            g = (int)(actualColor.G * brightness);
                            b = (int)(actualColor.B * brightness);

                            if (r > 255) r = 255;
                            else if (r < 0) r = 0;

                            if (g > 255) g = 255;
                            else if (g < 0) g = 0;

                            if (b > 255) b = 255;
                            else if (b < 0) b = 0;

                            newColor = Color.FromArgb(r, g, b);
                        }
                        else
                        {
                            newColor = bmp.GetPixel(j, i);
                        }
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
    }
}
