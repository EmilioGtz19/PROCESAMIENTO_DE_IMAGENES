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
    }
}
