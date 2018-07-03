namespace Pacman
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnJugar = new System.Windows.Forms.Button();
            this.BtnHighscores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a Pacman";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(318, 146);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(136, 26);
            this.Nombre.TabIndex = 1;
            this.Nombre.UseSystemPasswordChar = true;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // BtnJugar
            // 
            this.BtnJugar.Location = new System.Drawing.Point(331, 231);
            this.BtnJugar.Name = "BtnJugar";
            this.BtnJugar.Size = new System.Drawing.Size(110, 45);
            this.BtnJugar.TabIndex = 3;
            this.BtnJugar.Text = "Jugar";
            this.BtnJugar.UseVisualStyleBackColor = true;
            this.BtnJugar.Click += new System.EventHandler(this.BtnJugar_Click);
            // 
            // BtnHighscores
            // 
            this.BtnHighscores.Location = new System.Drawing.Point(331, 313);
            this.BtnHighscores.Name = "BtnHighscores";
            this.BtnHighscores.Size = new System.Drawing.Size(110, 71);
            this.BtnHighscores.TabIndex = 4;
            this.BtnHighscores.Text = "Tabla Puntajes Históricos";
            this.BtnHighscores.UseVisualStyleBackColor = true;
            this.BtnHighscores.Click += new System.EventHandler(this.BtnHighscores_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnHighscores);
            this.Controls.Add(this.BtnJugar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnJugar;
        private System.Windows.Forms.Button BtnHighscores;
    }
}

