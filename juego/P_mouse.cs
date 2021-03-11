using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego
{
    public partial class P_mouse : Form
    {
        int Puntos = 0;

        public P_mouse()
        {
            InitializeComponent();
        }

        private void volverAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Me = new Menu();

            Me.Show();
            this.Close();

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Punto_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();


            int X = rnd.Next(27, 700);
            int Y = rnd.Next(27, 410);

            Puntos++;
            Punto.Location = new Point(X, Y);

            label1.Text = "Puntaje: " + Puntos;
        }


        private void P_mouse_Load(object sender, EventArgs e)
        {

        }


    }
}


