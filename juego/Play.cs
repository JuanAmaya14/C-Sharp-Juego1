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
    public partial class Play : Form
    {

        int Puntos = 0;

        public Play()
        {
            
             
            InitializeComponent();

        }

        private void Botones(object sender, KeyEventArgs e)
        {


            if (e.KeyData == Keys.A)
            {
                Per.Location = new Point(Per.Location.X - 10, Per.Location.Y);
            }

            if (e.KeyData == Keys.D)
            {
                Per.Location = new Point(Per.Location.X + 10, Per.Location.Y);
            }

            ///////////////////////////////////////

             if (e.KeyData == Keys.W)
              {
                  Per.Location = new Point(Per.Location.X, Per.Location.Y - 10);

              }

            if (e.KeyData == Keys.S)
            {
                Per.Location = new Point(Per.Location.X, Per.Location.Y + 10);

            }


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

        
    }
}
        

