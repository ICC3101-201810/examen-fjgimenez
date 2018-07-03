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
    public partial class Inicio : Form
    {
        BaseDeDatos db = new BaseDeDatos();

        public Inicio()
        {
            InitializeComponent();
             db.jugador.Add(new Jugador("Pepito", 0));

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nombre = Nombre.Text;
            
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {

            Form juego = new Juego();
            juego.Show();
        }

        private void BtnHighscores_Click(object sender, EventArgs e)
        {
            Form Highscores = new Highscores();
            Highscores.Show();
        }
    }
}
