﻿using System;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (radioButton1.Checked == true )
            {
                Form1 abrir = new Form1();
                abrir.Show();
                this.Hide();
            }
           if (radioButton2.Checked == true)
            {

                Venta abrir2 = new Venta();
                abrir2.Show();
                this.Hide();

            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {            
        }
    }
}
