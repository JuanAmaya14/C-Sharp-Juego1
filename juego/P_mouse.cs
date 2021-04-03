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
    public partial class P_mouse : Form
    {
        SoundPlayer HereNow = new SoundPlayer();
        SoundPlayer Mine = new SoundPlayer();
        SoundPlayer BTB = new SoundPlayer();
        SoundPlayer Radius = new SoundPlayer();
        SoundPlayer Cuba = new SoundPlayer();
        SoundPlayer June_Instru = new SoundPlayer();




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

        private void pararMusicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HereNow.Stop();
            Mine.Stop();
            BTB.Stop();
            Radius.Stop();
            Cuba.Stop();
            June_Instru.Stop();

        }

        private void hereNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HereNow.SoundLocation = "C:/Users/JuanK/Desktop/C-Sharp-Juego1/juego/Audio/RJD2/Here_Now.wav";
            HereNow.Play();

        }

        

        private void aBeautifulMineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mine.SoundLocation = "C:/Users/JuanK/Desktop/C-Sharp-Juego1/juego/Audio/RJD2/Mine.wav";
            Mine.Play();


        }

        private void beyondTheBeyondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTB.SoundLocation = "C:/Users/JuanK/Desktop/C-Sharp-Juego1/juego/Audio/RJD2/BTB.wav";
            BTB.Play();

        }

        private void newRadiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Radius.SoundLocation = "C:/Users/JuanK/Desktop/C-Sharp-Juego1/juego/Audio/RJD2/New-Radius.wav";
            Radius.Play();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Cuba.SoundLocation = "C:/Users/JuanK/Desktop/C-Sharp-Juego1/juego/Audio/RJD2/rjd2-1976.wav";
            Cuba.Play();

        }

        

        private void juneInstrumentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            June_Instru.SoundLocation = "C:/Users/JuanK/Desktop/seguro/juego/Audio/RJD2/june-instrumental.wav";
            June_Instru.Play();

        }

        private void sFlavCallToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}


