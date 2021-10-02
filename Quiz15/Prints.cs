using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz15
{
    class Prints
    {
        public static void visualizarMovimientosPosibles(Tablero tablero)
        {
            int[] movimientosPosibles = tablero.retornarMovimientosPos();
            for (int i = 0; i < 4; i++)
            {
                if (movimientosPosibles[i] == 1)
                {
                    Console.WriteLine("D. Mover a la derecha\n");
                }
                if (movimientosPosibles[i] == 2)
                {
                    Console.WriteLine("A. Mover a la izquierda\n");
                }
                if (movimientosPosibles[i] == 3)
                {
                    Console.WriteLine("S. Mover abajo\n");
                }
                if (movimientosPosibles[i] == 4)
                {
                    Console.WriteLine("W. Mover arriba\n");
                }
            }
        }

        public static void VisualizarPartida(Tablero tablero, Jugador jugador)
        {
            jugador.toString();
            tablero.toString();
            visualizarMovimientosPosibles(tablero);
        }

    }
}
