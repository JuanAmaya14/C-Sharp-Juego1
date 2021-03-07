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

            /////////////////////////////////////////////////////////////////////////////
            // ------------------------- CONTROLES ------------------------------------//
            /////////////////////////////////////////////////////////////////////////////
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
            //////////////////////////////////////////////////////////////////////////////////////////
            //--------------------------------------- PAREDES --------------------------------------//
            //////////////////////////////////////////////////////////////////////////////////////////
            label2.Text = ("X:  "+Per.Location.X+" - Y: "+Per.Location.Y);


            if (Per.Location.Y <= Pared_Arriba.Location.Y)
            {

                Per.Location = new Point(Per.Location.X, +379); 

            }

            if (Per.Location.Y >= Pared_Abajo.Location.Y)
            {

                Per.Location = new Point(Per.Location.X, +27);

            }

            if (Per.Location.X >= Pared_Derecha.Location.X)
            {

                Per.Location = new Point(+9, Per.Location.Y);

            }

            if (Per.Location.X <= Pared_Izquierda.Location.X)
            {

                Per.Location = new Point(+761, Per.Location.Y);

            }

            //////////////////////////////////////////////////////////////////////////////////////////
            //--------------------------------------- GALLETA --------------------------------------//
            //////////////////////////////////////////////////////////////////////////////////////////

            if(Per.Location.X > Galleta.Location.X && Per.Location.Y > Galleta.Location.Y &&
               Per.Location.X <= Galleta.Location.X +40 && Per.Location.Y <= Galleta.Location.Y +40) 
            {
                Random rnd = new Random();

                int X = rnd.Next(27, 700);
                int Y = rnd.Next(27, 410);



                Puntos++;
               Galleta.Location = new Point(X,Y);

                label1.Text = "Puntaje: "+Puntos;
                


                
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
        

