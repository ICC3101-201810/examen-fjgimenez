namespace Pacman
{
    partial class Juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPuntaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picturePacman = new System.Windows.Forms.PictureBox();
            this.pictureUva = new System.Windows.Forms.PictureBox();
            this.pictureFantasmaRosado = new System.Windows.Forms.PictureBox();
            this.pictureCereza = new System.Windows.Forms.PictureBox();
            this.pictureFantasmaRojo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFantasmaRosado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCereza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFantasmaRojo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(321, 30);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(123, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "NombreJugador";
            // 
            // labelPuntaje
            // 
            this.labelPuntaje.AutoSize = true;
            this.labelPuntaje.Location = new System.Drawing.Point(98, 30);
            this.labelPuntaje.Name = "labelPuntaje";
            this.labelPuntaje.Size = new System.Drawing.Size(63, 20);
            this.labelPuntaje.TabIndex = 1;
            this.labelPuntaje.Text = "Puntaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puntaje:";
            // 
            // picturePacman
            // 
            this.picturePacman.BackgroundImage = global::Pacman.Properties.Resources.pacman1;
            this.picturePacman.Location = new System.Drawing.Point(394, 160);
            this.picturePacman.Name = "picturePacman";
            this.picturePacman.Size = new System.Drawing.Size(50, 50);
            this.picturePacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturePacman.TabIndex = 7;
            this.picturePacman.TabStop = false;
            //this.picturePacman.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.picturePacman_KeyDown);
            // 
            // pictureUva
            // 
            this.pictureUva.BackgroundImage = global::Pacman.Properties.Resources.uva;
            this.pictureUva.Location = new System.Drawing.Point(671, 336);
            this.pictureUva.Name = "pictureUva";
            this.pictureUva.Size = new System.Drawing.Size(40, 50);
            this.pictureUva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureUva.TabIndex = 6;
            this.pictureUva.TabStop = false;
            // 
            // pictureFantasmaRosado
            // 
            this.pictureFantasmaRosado.BackgroundImage = global::Pacman.Properties.Resources.fantasmarosado;
            this.pictureFantasmaRosado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureFantasmaRosado.Location = new System.Drawing.Point(82, 336);
            this.pictureFantasmaRosado.Name = "pictureFantasmaRosado";
            this.pictureFantasmaRosado.Size = new System.Drawing.Size(50, 50);
            this.pictureFantasmaRosado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureFantasmaRosado.TabIndex = 5;
            this.pictureFantasmaRosado.TabStop = false;
            // 
            // pictureCereza
            // 
            this.pictureCereza.BackgroundImage = global::Pacman.Properties.Resources.cereza;
            this.pictureCereza.Location = new System.Drawing.Point(82, 108);
            this.pictureCereza.Name = "pictureCereza";
            this.pictureCereza.Size = new System.Drawing.Size(50, 50);
            this.pictureCereza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureCereza.TabIndex = 4;
            this.pictureCereza.TabStop = false;
            // 
            // pictureFantasmaRojo
            // 
            this.pictureFantasmaRojo.BackgroundImage = global::Pacman.Properties.Resources.fanasmarojo1;
            this.pictureFantasmaRojo.Location = new System.Drawing.Point(661, 77);
            this.pictureFantasmaRojo.Name = "pictureFantasmaRojo";
            this.pictureFantasmaRojo.Size = new System.Drawing.Size(50, 50);
            this.pictureFantasmaRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureFantasmaRojo.TabIndex = 3;
            this.pictureFantasmaRojo.TabStop = false;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picturePacman);
            this.Controls.Add(this.pictureUva);
            this.Controls.Add(this.pictureFantasmaRosado);
            this.Controls.Add(this.pictureCereza);
            this.Controls.Add(this.pictureFantasmaRojo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPuntaje);
            this.Controls.Add(this.labelNombre);
            this.Name = "Juego";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFantasmaRosado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCereza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFantasmaRojo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPuntaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureFantasmaRojo;
        private System.Windows.Forms.PictureBox pictureCereza;
        private System.Windows.Forms.PictureBox pictureFantasmaRosado;
        private System.Windows.Forms.PictureBox pictureUva;
        private System.Windows.Forms.PictureBox picturePacman;
    }
}