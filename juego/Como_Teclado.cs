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
    public partial class Modo_Teclado : Form
    {
        public Modo_Teclado()
        {
            InitializeComponent();
        }

        private void A_ins_Click(object sender, EventArgs e)
        {
            Form Me = new Menu();

            Me.Show();

            this.Hide();
        }

        private void Como_Jugar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form CM = new Como_Mouse();
            CM.Show();

            this.Hide();
        }
    }
}
