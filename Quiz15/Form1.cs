using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz15
{
    public partial class Form1 : Form
    {
        private Archivo archivo;

        private Juego juego;
        private List<Button> list;
        private string nombreJugador;

        public Form1(string nombre)
        {
            InitializeComponent();
            juego = new Juego(nombre);
            list = new List<Button>();
            list.Add(button1);
            list.Add(button2);
            list.Add(button3);
            list.Add(button4);
            list.Add(button5);
            list.Add(button6);
            list.Add(button7);
            list.Add(button8);
            list.Add(button9);
            list.Add(button10);
            list.Add(button11);
            list.Add(button12);
            list.Add(button13);
            list.Add(button14);
            list.Add(button15);
            list.Add(button16);
            nombreJugador = nombre;
            archivo = new Archivo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = nombreJugador;
            metodo();
        }

        public Archivo GetArchivo()
        {
            return archivo;
        }

        private void metodo()
        {
            int contador = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    list[contador].Text = juego.Tablero.retornarValorTablero(i, j).ToString();
                    contador++;
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Text == "16")
                {
                    list[i].Visible = false;
                }
                else
                {
                    list[i].Visible = true;
                }
            }

            if (juego.Tablero.estadoTablero() == true)
            {
                MessageBox.Show("Felicidades has ganado el juego!!");
                archivo.guardarJugador(juego.Jugador);
                this.Close();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button1.Text);
            metodo();

            if(updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button2.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button3.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button4.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button5.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button6.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button7.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button8.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button9.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button10.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button11.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }

        }
        private void button12_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button12.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }

        }
        private void button13_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button13.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }

        }
        private void button14_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button14.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }

        }
        private void button15_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button15.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            bool updateNumMov = juego.Tablero.mover(button16.Text);
            metodo();
            if (updateNumMov == true)
            {
                int valor = int.Parse(label4.Text);
                valor++;
                label4.Text = valor.ToString();
                juego.Jugador.NumMovimientos = valor;
            }
        }
        
        public Button retornarBoton(int i)
        {
            return list[i];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
