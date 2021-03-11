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
    public partial class Como_Mouse : Form
    {
        public Como_Mouse()
        {
            InitializeComponent();
        }

        private void A_ins_Click(object sender, EventArgs e)
        {
            Form MM = new Modo_Teclado();

            MM.Show();

            this.Hide();
        }
    }
}
