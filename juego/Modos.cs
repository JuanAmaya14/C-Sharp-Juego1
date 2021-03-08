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
    public partial class Modos : Form
    {
        public Modos()
        {
            InitializeComponent();
        }

        private void Mouse_Click(object sender, EventArgs e)
        {
            Form ME = new Menu();
            Form MO = new Modos();
            Form Mouse = new P_mouse();

            this.Hide();


            ME.Hide();
            MO.Hide();

            Mouse.Show();
        }

        private void Teclado_Click(object sender, EventArgs e)
        {
            Form ME = new Menu();
            Form MO = new Modos();
            Form PL = new Play();

            this.Hide();


            ME.Hide();
            MO.Hide();

            PL.Show();
        }

        private void volverAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Me = new Menu();

            Me.Show();
            this.Close();
        }
    }
}
