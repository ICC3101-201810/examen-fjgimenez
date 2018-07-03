using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class BaseDeDatos
    {
        //listas de objetos creables
        public List<Jugador> jugador = new List<Jugador>();
        public List<FantasmaRojo> fantasmarojo = new List<FantasmaRojo>();
        public List<FantasmaRosado> fantasmarosado = new List<FantasmaRosado>();
        public List<Uva> uva = new List<Uva>();
        public List<Cereza> cereza = new List<Cereza>();

        public BaseDeDatos()
        {
        }
    }
}
