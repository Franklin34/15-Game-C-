using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz15
{
    public class Archivo
    {
        private StreamWriter sw;
        private int contador;

        public Archivo()
        {
            try
            {
                FileStream stream = new FileStream("bitacora.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(stream);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            contador = 0;
        }

        public void guardarJugador(Jugador jugador)
        {
            if (contador == 0)
            {
                sw.Write("El nombre del jugador es: " + jugador.Nombre + "\n");
                sw.Write("El numero de movimientos realizados: " + jugador.NumMovimientos + " \n\n");
                contador++;
            }
        }

        public void cerrarArchivo()
        {
            sw.Close();
        }
    }
}
