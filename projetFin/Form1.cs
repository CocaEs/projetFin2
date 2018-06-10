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
    public partial class Form1 : Form
    {
         int poc;

         List<Administrador> datotemp = new List<Administrador>();
         List<Administrador> agregar = new List<Administrador>();

        public Form1()
        {
            InitializeComponent();


            /*  string fileName = "productos.txt";
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

              reader.Close();*/
            //for (int i = 0; i < datotemp.Count; i++)
            //{
            //    comboBox1.Items.Add(datotemp[i].Nombreproducto);
            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            Administrador adtemp = new Administrador();
            adtemp.Nombreproducto = textBox1.Text;
            adtemp.Precioproducto = textBox2.Text;
            adtemp.Cantidadproducto = textBox3.Text;

            agregar.Add(adtemp);

            string fileName = "productos.txt";
           
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

        private void button3_Click(object sender, EventArgs e)
        {
            MenuPrincipal regresa2 = new MenuPrincipal();
            regresa2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Administrador> listem = new List<Administrador>();

            string fileName = "productos.txt"; 
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Administrador listatemp = new Administrador();

                listatemp.Nombreproducto = reader.ReadLine();
                listatemp.Precioproducto = reader.ReadLine();
                listatemp.Cantidadproducto = reader.ReadLine();

                listem.Add(listatemp);
            }
          
            reader.Close();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = listem;
            dataGridView1.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrador adtemp = new Administrador();
            adtemp.Nombreproducto = textBox1.Text;
            adtemp.Precioproducto = textBox2.Text;
            adtemp.Cantidadproducto = textBox3.Text;


            string fileName = "productos.txt";
            //Para que sobreescriba los datos existentes se usa CREATE
            FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            dataGridView1[0, poc].Value = textBox1.Text;
            dataGridView1[1, poc].Value = textBox2.Text;
            dataGridView1[2, poc].Value = textBox3.Text;

            for (int i = 0; i < agregar.Count ; i++)
            {
                if (agregar[i].Nombreproducto==textBox1.Text )
                {
                    agregar[i].Cantidadproducto = textBox2.Text;
                    agregar[i].Precioproducto = textBox3.Text;
                    break;
                }
            }
            for (int i = 0; i < agregar.Count; i++)
            {
                writer.WriteLine(agregar[i].Nombreproducto);
                writer.WriteLine(agregar[i].Cantidadproducto);
                writer.WriteLine(agregar[i].Precioproducto);
            }
            //Se recorre toda la lista de clientes, que incluye a los ya modificados y se vuelve a grabar al archivo
            
            //Cerrar el archivo
            writer.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";    
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1[0,poc].Value.ToString();
            textBox2.Text = dataGridView1[1, poc].Value.ToString();
            textBox3.Text = dataGridView1[2, poc].Value.ToString();
        }
    }
}
