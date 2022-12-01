using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using Emgu.CV;
using Emgu.CV.Structure;

namespace PROCESAMIENTO_DE_IMAGENES
{
    public partial class frmDetector : Form
    {

        private FilterInfoCollection myDevices;
        private VideoCaptureDevice myWebcam;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        Random random = new Random();       
        Rectangle[] rectangles = null;

        public frmDetector()
        {
            InitializeComponent();
        }

        private void FrmDetector_Load(object sender, EventArgs e)
        {
            LoadDevices();
        }

        public void LoadDevices()
        {
            myDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if(myDevices.Count > 0)
            {

                for(int i = 0; i < myDevices.Count; i++)
                    cbDevices.Items.Add(myDevices[i].Name.ToString());
                                                         
            }
        }

        public void CloseWebcam()
        {
            if(myWebcam != null && myWebcam.IsRunning)
            {
                myWebcam.SignalToStop();
                myWebcam = null;
                cameraBox.Image = PROCESAMIENTO_DE_IMAGENES.Properties.Resources.camera;
            }
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            CloseWebcam();
            int i = cbDevices.SelectedIndex;

            if (i > -1)
            {
                string nameDevice = myDevices[i].MonikerString;
                myWebcam = new VideoCaptureDevice(nameDevice);
                myWebcam.NewFrame += new NewFrameEventHandler(CaptureWebcam);
                myWebcam.Start();          
            }
            else
            {
                MessageBox.Show("Ninguna camara seleccionada", "Detector de Personas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CaptureWebcam(object sender, NewFrameEventArgs eventArgs)
        {
            int i = 1;
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            Font arial = new Font("Arial", 20, FontStyle.Regular);
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(image);
            Brush brush = new SolidBrush(Color.FromKnownColor(KnownColor.Black));
            rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
            Pen pen = new Pen(Color.Red,7);

            foreach(Rectangle rectangle in rectangles)
            {
                using(Graphics graphics = Graphics.FromImage(image))
                {                                        
                        graphics.DrawRectangle(pen, rectangle);
                        graphics.DrawString(i++.ToString(), arial, brush, rectangle);                    
                }
            }
            cameraBox.Image = image;          
        }

        private void FrmDetector_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseWebcam();
        }

    
    }
}
