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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Abrir formularios hijos en el panel contenedor (panelChildForm)
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void BtnEditImage_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEditImage());
        }

        private void BtnEditVideo_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEditVideo());
        }

        private void BtnCamera_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDetector());
        }

        private void BtnUserManual_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUserManual());
        }

        private void PanelLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

    }
}
