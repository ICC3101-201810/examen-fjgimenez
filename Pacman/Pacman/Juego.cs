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
        public Juego(Jugador j)
        {
           
                labelNombre.Text = "Nombre:" + j.NombreJugador;
            
        }

        private void Juego_Load(object sender, EventArgs e)
        {

        }
    }
}
