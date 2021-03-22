using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace juego
{
    public partial class Play : Form
    {
        SoundPlayer HereNow = new SoundPlayer();
        SoundPlayer Mine = new SoundPlayer();
        SoundPlayer BTB = new SoundPlayer();
        SoundPlayer Radius = new SoundPlayer();
        SoundPlayer Cuba = new SoundPlayer();
        SoundPlayer June_Instru = new SoundPlayer();

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
            label2.Text = ("X:  " + Per.Location.X + " - Y: " + Per.Location.Y);


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

            if (Per.Location.X > Galleta.Location.X && Per.Location.Y > Galleta.Location.Y &&
               Per.Location.X <= Galleta.Location.X + 40 && Per.Location.Y <= Galleta.Location.Y + 40)
            {
                Random rnd = new Random();

                int X = rnd.Next(27, 700);
                int Y = rnd.Next(27, 410);



                Puntos++;
                Galleta.Location = new Point(X, Y);

                label1.Text = "Puntaje: " + Puntos;

            }


        }

        private void volverAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Me = new Menu();

            Me.Show();
            this.Close();

            HereNow.Stop();
            Mine.Stop();
            BTB.Stop();
            Radius.Stop();
            Cuba.Stop();
            June_Instru.Stop();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Play_Load(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////
            ////--------------------------------------- Reset --------------------------------------////
            ////////////////////////////////////////////////////////////////////////////////////////////

            Puntos = 0;



        }

        private void hereNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HereNow.SoundLocation = "C:/Users/JuanK/Desktop/C-Sharp-Juego1-main/juego/Audio/RJD2/Here_Now.wav";
            HereNow.Play();
        }

        private void aBeautifulMineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mine.SoundLocation = "C:/Users/JuanK/Desktop/C-Sharp-Juego1-main/juego/Audio/RJD2/Mine.wav";
            Mine.Play();
        }

        private void beyondTheBeyondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTB.SoundLocation = "C:/Users/JuanK/Desktop/C-Sharp-Juego1-main/juego/Audio/RJD2/BTB.wav";
            BTB.Play();
        }

        private void newRadiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Radius.SoundLocation = "C:/Users/JuanK/Desktop/C-Sharp-Juego1-main/juego/Audio/RJD2/New-Radius.wav";
            Radius.Play();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cuba.SoundLocation = "C:/Users/JuanK/Desktop/C-Sharp-Juego1-main/juego/Audio/RJD2/rjd2-1976.wav";
            Cuba.Play();
        }

        private void juneInstrumentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            June_Instru.SoundLocation = "C:/Users/JuanK/Desktop/C-Sharp-Juego1-main/juego/Audio/RJD2/june-instrumental.wav";
            June_Instru.Play();
        }

        private void pararMusicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HereNow.Stop();
            Mine.Stop();
            BTB.Stop();
            Radius.Stop();
            Cuba.Stop();
            June_Instru.Stop();
        }
    }
}


