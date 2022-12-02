using Emgu.CV;
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
    public partial class frmEditVideo : Form
    {
        VideoCapture video;
        bool pause = false;

        
        private Bitmap bmpVideo;
        private Bitmap original;
        private SaveFileDialog saveAvi;
        private Color actualColor, newColor;
        private int filter;

        public frmEditVideo()
        {
            InitializeComponent();
        }

        private async void BtnUpload_ClickAsync(object sender, EventArgs e)
        {
            OpenFileDialog OpenVideo = new OpenFileDialog
            {
                Filter = "Image files (*.mp4)|*.mp4"
            };

            if (OpenVideo.ShowDialog() == DialogResult.OK)
            {
                video = new VideoCapture(OpenVideo.FileName);
                Mat mat = new Mat();

                Bitmap originalImage = mat.Bitmap;

                while (!pause)
                {
                    video.Read(mat);
                    if (!mat.IsEmpty)
                    {
                        bmpVideo = mat.Bitmap;
                        original = mat.Bitmap;
                        switch (filter)
                        {
                            case 0:
                                bmpVideo = mat.Bitmap;
                                break;
                            case 1:
                                Negative();
                                break;
                            case 2:
                                GrayScale();
                                break;
                            case 3:
                                Sepia();
                                break;
                            case 4:
                                Noise();
                                break;
                            default:
                                bmpVideo = mat.Bitmap;
                                break;
                        }

                        videoBox.Image = bmpVideo;
                        videoBox.SizeMode = PictureBoxSizeMode.StretchImage;


                        double fps = video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                        await Task.Delay(1000 / Convert.ToInt32(fps));
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }



        private async void BtnPlay_Click(object sender, EventArgs e)
        {
            if (video == null)
            {
                MessageBox.Show("Ningun video cargado", "Reproducir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Mat mat = new Mat();

            pause = false;
            while (!pause)
            {

                video.Read(mat);

                if (!mat.IsEmpty)
                {
                    videoBox.Image = mat.Bitmap;
                    bmpVideo = mat.Bitmap;
                    double fps = video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                    await Task.Delay(1000 / Convert.ToInt32(fps));
                }
                else
                {
                    break;
                }

            }
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (video == null)
            {
                MessageBox.Show("Ningun video cargado", "Reproducir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pause = true;
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            if (videoBox.Image != null)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de borrar tu progreso?", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    videoBox.Image.Dispose();
                    videoBox.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Ningun video cargado", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {

        }

        


        private void Noise()
        {
            if (bmpVideo != null)
            {
                int percentage = 150;
                int minRange = 85;
                int maxRange = 115;
                float brightness;
                Random rand = new Random();
                int r, g, b;
                videoBox.Image = bmpVideo;
                bmpVideo = new Bitmap(original.Width, original.Height);

                for (int j = 0; j < original.Width; j++)
                    for (int i = 0; i < original.Height; i++)
                    {
                        if (rand.Next(1, 100) <= percentage)
                        {
                            brightness = rand.Next(minRange, maxRange) / 100.0f;
                            actualColor = original.GetPixel(j, i);

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
                            newColor = original.GetPixel(j, i);
                        }
                        bmpVideo.SetPixel(j, i, newColor);
                    }
            }
        }

        private void Negative()
        {
            if (bmpVideo != null)
            {
                videoBox.Image = bmpVideo;
                bmpVideo = new Bitmap(original.Width, original.Height);

                for (int j = 0; j < original.Width; j++)
                    for (int i = 0; i < original.Height; i++)
                    {
                        actualColor = original.GetPixel(j, i);
                        newColor = Color.FromArgb(255 - actualColor.R, 255 - actualColor.G, 255 - actualColor.B);
                        bmpVideo.SetPixel(j, i, newColor);
                    }
            }
        }

        private void GrayScale()
        {
            if (bmpVideo != null)
            {
                videoBox.Image = bmpVideo;
                bmpVideo = new Bitmap(original.Width, original.Height);

                for (int j = 0; j < original.Width; j++)
                    for (int i = 0; i < original.Height; i++)
                    {
                        actualColor = original.GetPixel(j, i);
                        newColor = Color.FromArgb(actualColor.R, actualColor.R, actualColor.R);
                        bmpVideo.SetPixel(j, i, newColor);
                    }

          
            }
        }

        private void Sepia()
        {
            if (bmpVideo != null)
            {
                videoBox.Image = bmpVideo;
                bmpVideo = new Bitmap(original.Width, original.Height);

                for (int j = 0; j < original.Width; j++)
                    for (int i = 0; i < original.Height; i++)
                    {
                        actualColor = original.GetPixel(j, i);

                        int a = actualColor.A;
                        int r = actualColor.R;
                        int g = actualColor.G;
                        int b = actualColor.B;

                        int tempR = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                        int tempG = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                        int tempB = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                        if (tempR > 255) r = 255;
                        else r = tempR;

                        if (tempG > 255) g = 255;
                        else g = tempG;

                        if (tempB > 255) b = 255;
                        else b = tempB;

                        bmpVideo.SetPixel(j, i, Color.FromArgb(a, r, g, b));
                    }
            }
        }

        private void BtnNegative_Click(object sender, EventArgs e)
        {
            filter = 1;
        }

        private void btnGrayScale_Click(object sender, EventArgs e)
        {
            filter = 2;
        }

        private void btnSepia_Click(object sender, EventArgs e)
        {
            filter = 3;
        }

        private void btnNoise_Click(object sender, EventArgs e)
        {
            filter = 4;
        }
    }
}
