using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz15
{
    class Jugador
    {
        private string nombre;
        private int numMovimientos;

        public Jugador()
        {
            nombre = "";
            numMovimientos = 0;
        }
        public Jugador(string nombre)
        {
            this.nombre = nombre;
            this.numMovimientos = 0;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int NumMovimientos
        {
            get { return numMovimientos; }
            set { numMovimientos = value; }
        }

        public void toString()
        {
            Console.Write("Jugador: ");
            Console.Write(nombre);
            Console.Write(" | ");
            Console.Write("Movimientos: ");
            Console.Write(numMovimientos);
            Console.Write("\n\n");
        }
    }
}
