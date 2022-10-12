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

namespace PROCESAMIENTO_DE_IMAGENES
{
    public partial class frmDetector : Form
    {

        private FilterInfoCollection myDevices;
        private VideoCaptureDevice myWebcam;

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

            if (i > 0)
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
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            cameraBox.Image = image;
        }

        private void FrmDetector_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseWebcam();
        }
    }
}
