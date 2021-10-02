using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz15
{
    class Menu
    {
        private Juego juego;

        public Menu()
        {
            juego = new Juego();
        }

        public void menuJugador()
        {
            string nombre;
            Console.WriteLine("Digite su nombre: ");
            nombre = Console.ReadLine();
            juego.Jugador.Nombre = nombre;
        }

        public string pedirMovimiento()
        {
            string movimiento;
            do
            {
                Console.WriteLine("Digite su movimiento: ");
                movimiento = Console.ReadLine();
                movimiento = movimiento.ToUpper();
            } while (movimiento != "A" && movimiento != "D" && movimiento != "S" && movimiento != "W");

            return movimiento;
        }

        public void menuPrincipal()
        {
            menuJugador();
            Archivo archivos = new Archivo();
            Console.Clear();

            while (juego.Tablero.estadoTablero() == false)
            {
                Console.Clear();
                Prints.VisualizarPartida(juego.Tablero, juego.Jugador);
                Console.WriteLine("\n", "");
                juego.realizarMovimiento(pedirMovimiento());
                Console.WriteLine("\n", "");
            }

            if (juego.Tablero.estadoTablero() == true)
            {
                Console.Clear();
                Prints.VisualizarPartida(juego.Tablero, juego.Jugador);
                Console.WriteLine("\n", "");
                Console.WriteLine("Felicidades has ganado el juego");
                Console.WriteLine("\n", "");
                archivos.guardarJugador(juego.Jugador);
                return;
            }

        }

    }
}
