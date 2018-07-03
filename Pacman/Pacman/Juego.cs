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
    public partial class Juego : Form
    {
        BaseDeDatos db = new BaseDeDatos();
        public static Tablero tablero = new Tablero();
        public static Pacman pacman = new Pacman();

        public Juego()
        {
            InitializeComponent();
            db.fantasmarojo.Add(new FantasmaRojo("Rojo"));
            db.fantasmarosado.Add(new FantasmaRosado("Rosado"));

            db.uva.Add(new Uva("Uva", 15));
            db.cereza.Add(new Cereza("Cereza", 10));

            //labelNombre.Text = j.NombreJugador;
        }

        private void Juego_Load(object sender, EventArgs e)
        {

        }
        
            protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                //case Keys.Up: picturePacman.nextDirection = 1; picturePacman.MovePacman(1); break;
                //case Keys.Right: picturePacman.nextDirection = 2; picturePacman.MovePacman(2); break;
                //case Keys.Down: picturePacman.nextDirection = 3; picturePacman.MovePacman(3); break;
                //case Keys.Left: picturePacman.nextDirection = 4; picturePacman.MovePacman(4); break;
            }
        }
    }
}
