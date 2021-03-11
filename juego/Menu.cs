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
    public partial class Menu : Form
    {

       

        public Menu()
        {
            InitializeComponent();
        }





        private void B_Acerca_De_Click(object sender, EventArgs e)
        {
            Form AD = new Acerca_De();
            Form ME = new Menu();

            AD.Show();
            this.Hide();


        }

        private void B_como_jugar_Click(object sender, EventArgs e)
        {
            Form CJ = new Modo_Teclado();
            Form ME = new Menu();

            CJ.Show();
            this.Hide();
        }

        private void B_Jugar_Click(object sender, EventArgs e)
        {
            Form MO = new Modos();
            this.Hide();

            MO.Show();

            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
