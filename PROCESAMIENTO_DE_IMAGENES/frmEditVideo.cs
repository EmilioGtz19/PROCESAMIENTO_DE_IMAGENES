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
        Bitmap bmpVideo;

        public frmEditVideo()
        {
            InitializeComponent();
        }

        private void BtnUpload_ClickAsync(object sender, EventArgs e)
        {
            OpenFileDialog OpenVideo = new OpenFileDialog
            {
                Filter = "Image files (*.mp4)|*.mp4"
            };

            if (OpenVideo.ShowDialog() == DialogResult.OK)
            {
                video = new VideoCapture(OpenVideo.FileName);
                Mat mat = new Mat();
                video.Read(mat);
                videoBox.Image = mat.Bitmap;
                videoBox.SizeMode = PictureBoxSizeMode.StretchImage;              
            }
        }

        private async void BtnPlay_Click(object sender, EventArgs e)
        {
            if (video == null)
            {
                MessageBox.Show("Ningun video cargado", "Reproducir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pause = false;
            while (!pause)
            {
                Mat mat = new Mat();
                video.Read(mat);

                if (!mat.IsEmpty)
                {
                    videoBox.Image = mat.Bitmap;
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
    }
}
