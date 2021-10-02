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
            tablero = new Tablero(false);
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

        public void realizarMovimiento(string movimiento)
        {
            switch (movimiento)
            {
                case "A":
                    tablero.moverIzquierda();
                    jugador.NumMovimientos++;
                    break;
                case "S":
                    tablero.moverAbajo();
                    jugador.NumMovimientos++;
                    break;
                case "D":
                    tablero.moverDerecha();
                    jugador.NumMovimientos++;
                    break;
                case "W":
                    tablero.moverArriba();
                    jugador.NumMovimientos++;
                    break;
            }
        }
    }
}
