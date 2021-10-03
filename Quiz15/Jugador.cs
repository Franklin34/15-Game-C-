using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz15
{
    public class Jugador
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

        public override string ToString()
        {
            string cadena;
            cadena = "Jugador: " + nombre + " | " + "Movimientos: " + numMovimientos + "\n\n";
            return cadena;
        }
    }
}
