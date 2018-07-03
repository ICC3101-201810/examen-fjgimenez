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
        public Inicio()
        {
            InitializeComponent();

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            Form Juego = new Juego();
            Juego.Show();
        }

        private void BtnHighscores_Click(object sender, EventArgs e)
        {
            Form Highscores = new Highscores();
            Highscores.Show();
        }
    }
}
