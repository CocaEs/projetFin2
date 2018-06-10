using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetFin
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuPrincipal regresa = new MenuPrincipal();
            regresa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
