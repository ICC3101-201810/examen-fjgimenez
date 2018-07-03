using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Jugador
{
    public string NombreJugador { get; set; }
    public int PuntajeJugador { get; set; }

    public Jugador(string Nombre, int Puntaje)
    {
        this.NombreJugador = NombreJugador;
        this.PuntajeJugador = PuntajeJugador;
    }
}

