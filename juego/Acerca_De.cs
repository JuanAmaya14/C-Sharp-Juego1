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
    public partial class Acerca_De : Form
    {
        public Acerca_De()
        {
            InitializeComponent();
        }

        private void A_Acerca_de_Click(object sender, EventArgs e)
        {
            Form Me = new Menu();

            Me.Show();

            this.Hide();

        }
    }
}
