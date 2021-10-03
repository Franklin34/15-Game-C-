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

        private bool validarMovIzquierda(int jugador)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] == jugador)
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

        private bool validarMovAbajo(int jugador)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] == jugador)
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

        private bool validarMovArriba(int jugador)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] == jugador)
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

        public bool mover(string numero)
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
                                return true;
                            }
                        }
                    }
                }
            }
            if (validarMovIzquierda(valor) == true)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (tablero[i, j] == valor)
                        {
                            if (tablero[i, j - 1] == JUGADOR)
                            {
                                tablero[i, j] = JUGADOR;
                                tablero[i, j - 1] = valor;
                                return true;
                            }
                        }
                    }
                }
            }
            if (validarMovArriba(valor) == true)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (tablero[i, j] == valor)
                        {
                            if (tablero[i - 1, j] == JUGADOR)
                            {
                                tablero[i, j] = JUGADOR;
                                tablero[i - 1, j] = valor;
                                return true;
                            }
                        }
                    }
                }
            }
            if (validarMovAbajo(valor) == true)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (tablero[i, j] == valor)
                        {
                            if (tablero[i + 1, j] == JUGADOR)
                            {
                                tablero[i, j] = JUGADOR;
                                tablero[i + 1, j] = valor;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
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

        public override string ToString()
        {
            string cadena = "";
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    cadena = "\t" + "[ ";
                    if (tablero[i, j] == 16)
                    {
                        cadena += "";
                    }
                    else
                    {
                        cadena += tablero[i, j];
                    }
                    cadena +=  " ]";
                }
                cadena +=  "\n";
            }
            cadena += "\n";
            return cadena;
        }
    }
}
