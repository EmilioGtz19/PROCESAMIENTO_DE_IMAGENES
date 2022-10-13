namespace PROCESAMIENTO_DE_IMAGENES
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.btnUserManual = new FontAwesome.Sharp.IconButton();
            this.btnCamera = new FontAwesome.Sharp.IconButton();
            this.btnEditVideo = new FontAwesome.Sharp.IconButton();
            this.btnEditImage = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeftMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelLeftMenu.Controls.Add(this.btnUserManual);
            this.panelLeftMenu.Controls.Add(this.btnCamera);
            this.panelLeftMenu.Controls.Add(this.btnEditVideo);
            this.panelLeftMenu.Controls.Add(this.btnEditImage);
            this.panelLeftMenu.Controls.Add(this.btnExit);
            this.panelLeftMenu.Controls.Add(this.panelLogo);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(258, 670);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // btnUserManual
            // 
            this.btnUserManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManual.FlatAppearance.BorderSize = 0;
            this.btnUserManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnUserManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManual.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManual.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUserManual.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnUserManual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(221)))));
            this.btnUserManual.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUserManual.IconSize = 45;
            this.btnUserManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManual.Location = new System.Drawing.Point(0, 250);
            this.btnUserManual.Name = "btnUserManual";
            this.btnUserManual.Size = new System.Drawing.Size(258, 57);
            this.btnUserManual.TabIndex = 11;
            this.btnUserManual.Text = "Manual de Usuario";
            this.btnUserManual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserManual.UseVisualStyleBackColor = true;
            this.btnUserManual.Click += new System.EventHandler(this.BtnUserManual_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCamera.FlatAppearance.BorderSize = 0;
            this.btnCamera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamera.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamera.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCamera.IconChar = FontAwesome.Sharp.IconChar.CameraRetro;
            this.btnCamera.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(221)))));
            this.btnCamera.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCamera.IconSize = 45;
            this.btnCamera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamera.Location = new System.Drawing.Point(0, 193);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(258, 57);
            this.btnCamera.TabIndex = 10;
            this.btnCamera.Text = "Detector de Personas";
            this.btnCamera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.BtnCamera_Click);
            // 
            // btnEditVideo
            // 
            this.btnEditVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditVideo.FlatAppearance.BorderSize = 0;
            this.btnEditVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnEditVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditVideo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVideo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditVideo.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.btnEditVideo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(221)))));
            this.btnEditVideo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEditVideo.IconSize = 45;
            this.btnEditVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditVideo.Location = new System.Drawing.Point(0, 136);
            this.btnEditVideo.Name = "btnEditVideo";
            this.btnEditVideo.Size = new System.Drawing.Size(258, 57);
            this.btnEditVideo.TabIndex = 9;
            this.btnEditVideo.Text = "Editor de Videos";
            this.btnEditVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditVideo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditVideo.UseVisualStyleBackColor = true;
            this.btnEditVideo.Click += new System.EventHandler(this.BtnEditVideo_Click);
            // 
            // btnEditImage
            // 
            this.btnEditImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditImage.FlatAppearance.BorderSize = 0;
            this.btnEditImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnEditImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditImage.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditImage.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditImage.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnEditImage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(221)))));
            this.btnEditImage.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEditImage.IconSize = 45;
            this.btnEditImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditImage.Location = new System.Drawing.Point(0, 79);
            this.btnEditImage.Name = "btnEditImage";
            this.btnEditImage.Size = new System.Drawing.Size(258, 57);
            this.btnEditImage.TabIndex = 8;
            this.btnEditImage.Text = "Editor de Imagenes";
            this.btnEditImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditImage.UseVisualStyleBackColor = true;
            this.btnEditImage.Click += new System.EventHandler(this.BtnEditImage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(221)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnExit.IconSize = 45;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 613);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(258, 57);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(258, 79);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Click += new System.EventHandler(this.PanelLogo_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(258, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(925, 670);
            this.panelChildForm.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 60);
            this.panel1.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inicio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PROCESAMIENTO_DE_IMAGENES.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(359, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1183, 670);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelLeftMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Sublime Photo";
            this.panelLeftMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnUserManual;
        private FontAwesome.Sharp.IconButton btnCamera;
        private FontAwesome.Sharp.IconButton btnEditVideo;
        private FontAwesome.Sharp.IconButton btnEditImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
    }
}

