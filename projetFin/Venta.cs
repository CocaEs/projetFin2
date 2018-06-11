using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace projetFin
{
    public partial class Venta : Form
    {
        List<Clientes> clienteinfo = new List<Clientes>();
        List<Administrador> datotemp = new List<Administrador>();

        public Venta()
        {
            InitializeComponent();
            string fileName = "productos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Administrador nombretemp = new Administrador();

                nombretemp.Nombreproducto = reader.ReadLine();
                nombretemp.Precioproducto = reader.ReadLine();
                nombretemp.Cantidadproducto = reader.ReadLine();

                datotemp.Add(nombretemp);
            }

            reader.Close();
            for (int i = 0; i < datotemp.Count; i++)
            {
                comboBox1.Items.Add(datotemp[i].Nombreproducto);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            MenuPrincipal regresa = new MenuPrincipal();
            regresa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = clienteinfo;
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clientes adtemp = new Clientes();
            adtemp.Nombre = textBox1.Text;
            adtemp.Apellido= textBox2.Text;
            adtemp.Nit= textBox3.Text;

            clienteinfo.Add(adtemp);

            string fileName = "cliente.txt";

            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(textBox1.Text);
            writer.WriteLine(textBox2.Text);
            writer.WriteLine(textBox3.Text);
            writer.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fileName = "cliente.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //Se cargan los datos del archivo a la lista de clientes
            while (reader.Peek() > -1)
            {
                //Leer los datos y guardarlos en un temporal
                Clientes clientetemp = new Clientes();
                clientetemp.Nombre = reader.ReadLine();
                clientetemp.Apellido = reader.ReadLine();
                clientetemp.Nit = reader.ReadLine();
               

                //Agregar a la lista el temporal
                clienteinfo.Add(clientetemp);
            }
            reader.Close();
            int variable;
            //Se recorre la lista de clientes
            for (int i = 0; i < clienteinfo.Count; i++)
            {
                //Si se el dato a buscar es igual al dato de la lista mostrarlo en los textbox
                if (clienteinfo[i].Nit == textBox7.Text)
                {
                    textBox1.Text = clienteinfo[i].Nombre;
                    textBox2.Text = clienteinfo[i].Apellido;
                    textBox3.Text = clienteinfo[i].Nit;
                  
                    //Guardar en que posicion se encontró el dato para utilizarla mas adelante al momento de modificar
                    variable = i;

                }

            }

        }

        private void Venta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
