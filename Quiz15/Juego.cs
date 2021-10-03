using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz15
{
    class Juego
    {
        private Jugador jugador;
        private Tablero tablero;

        public Juego()
        {
            jugador = new Jugador();
            tablero = new Tablero(true);
        }

        public Juego(string nombre)
        {
            jugador = new Jugador(nombre);
            tablero = new Tablero(false);
        }

        public Jugador Jugador
        {
            get { return jugador; }
            set { jugador = value; }
        }

        public Tablero Tablero
        {
            get { return tablero; }
            set { tablero = value; }
        }
    }
}
