using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Highscores : Form
    {
        BaseDeDatos db = new BaseDeDatos();

        public Highscores()
        {
            InitializeComponent();
            db.jugador.Add(new Jugador("Pepito", 1340));
            db.jugador.Add(new Jugador("Juanito", 220));
            db.jugador.Add(new Jugador("María", 2090));

            for (int i = 0; i < this.db.jugador.Count; i++)
            {
                    //Create label
                    Label label = new Label();
                    label.Text = String.Format("{0}-{1}", i + 1, this.db.jugador[i].NombreJugador+ " " + this.db.jugador[i].PuntajeJugador);
                    //Position label on screen
                    label.Left = 10;
                    label.Top = (i + 1) * 30 + 30;
                    this.Controls.Add(label);
            }
        }

        private void Highscores_Load(object sender, EventArgs e)
        {

        }
    }
}
