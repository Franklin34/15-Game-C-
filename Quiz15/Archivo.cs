using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz15
{
    class Archivo
    {
        private StreamWriter sw;

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
        }
        public void guardarJugador(Jugador jugador)
        {
            sw.Write("El nombre del jugador es: " + jugador.Nombre + "\n");
            sw.Write("El numero de movimientos realizados: " + jugador.NumMovimientos + " \n\n");
            sw.Close();
        }
    }
}
