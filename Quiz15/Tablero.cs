using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz15
{
    class Tablero
    {
        private readonly int JUGADOR = 16;
        private int[,] tablero;
        private int filas;
        private int columnas;

        public Tablero()
        {
            tablero = new int[4, 4];
            filas = 0;
            columnas = 0;
        }

        public Tablero(bool trampa)
        {
            tablero = new int[4, 4];
            this.filas = 4;
            this.columnas = 4;
            llenarTablero(trampa);
        }
        private void llenarTablero(bool trampa)
        {
            int random = 0;
            int random2 = 1;
            Random r = new Random();

            if (trampa == false)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (random == 0)
                        {
                            random = r.Next(1, JUGADOR + 1);
                            tablero[i, j] = random;
                        }
                        else
                        {
                            while (verificarRepetido(random) == true)
                            {
                                random = r.Next(1, JUGADOR + 1);
                            }
                            tablero[i, j] = random;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        tablero[i, j] = random2++;
                    }
                }
                int valor = tablero[3, 3];
                tablero[3, 2] = valor;
                tablero[3, 3] = 15;
            }
        }

        private bool verificarRepetido(int num)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] == num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool estadoTablero()
        {
            int contador = 1;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] != contador)
                    {
                        return false;
                    }
                    contador++;
                }
            }
            return true;
        }

        private bool validarMovDerecha(int jugador)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] == jugador)
                    {
                        if (j == columnas - 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool validarMovIzquierda()
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] == JUGADOR)
                    {
                        if (j == 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool validarMovAbajo()
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] == JUGADOR)
                    {
                        if (i == filas - 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool validarMovArriba()
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] == JUGADOR)
                    {
                        if (i == 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public int[] retornarMovimientosPos()
        {
            int[] movimientos = new int[4];
            /*for (int i = 0; i < 4; i++)
            {
                movimientos[i] = 0;
            }
            if (validarMovDerecha() == true)
            {
                movimientos[0] = 1;
            }
            if (validarMovIzquierda() == true)
            {
                movimientos[1] = 2;
            }
            if (validarMovAbajo() == true)
            {
                movimientos[2] = 3;
            }
            if (validarMovArriba() == true)
            {
                movimientos[3] = 4;
            }*/
            return movimientos;
        }


        public void moverDerecha()
        {
            int valor = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] == JUGADOR)
                    {
                        valor = tablero[i, j + 1];
                        tablero[i, j] = valor;
                        tablero[i, j + 1] = JUGADOR;
                        return;
                    }
                }
            }
        }

        public void moverIzquierda()
        {
            int valor = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] == JUGADOR)
                    {
                        valor = tablero[i, j - 1];
                        tablero[i, j] = valor;
                        tablero[i, j - 1] = JUGADOR;
                        return;
                    }
                }
            }
        }

        public void moverArriba()
        {
            int valor = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] == JUGADOR)
                    {
                        valor = tablero[i - 1, j];
                        tablero[i, j] = valor;
                        tablero[i - 1, j] = JUGADOR;
                        return;
                    }
                }
            }
        }

        public void moverAbajo()
        {
            int valor = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] == JUGADOR)
                    {
                        valor = tablero[i + 1, j];
                        tablero[i, j] = valor;
                        tablero[i + 1, j] = JUGADOR;
                        return;
                    }
                }
            }
        }

        public void mover(string numero)
        {
            int valor = int.Parse(numero);

            if(validarMovDerecha(valor) == true)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (tablero[i, j] == valor)
                        {
                            if(tablero[i,j+1] == JUGADOR)
                            {
                                tablero[i, j] = JUGADOR;
                                tablero[i, j+1] = valor;
                                return;
                            }
                        }
                    }
                }
            }
        }

        public int Filas
        {
            get { return filas; }
            set { filas = value; }
        }
        public int Columnas
        {
            get { return columnas; }
            set { columnas = value; }
        }

        public int retornarValorTablero(int i, int y)
        {
            return tablero[i, y];
        }

        public void toString()
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("\t");
                    Console.Write("[ ");
                    if (tablero[i, j] == 16)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write(tablero[i, j]);
                    }
                    Console.Write(" ]");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
