using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yummy
{
   

    public partial class Form1 : Form
    {
        LisAsig lista = new LisAsig();

        List<Cliente> listaclientes = new List<Cliente>();
        List<Producto> listaproductos = new List<Producto>();
        public Form1()

        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"/img/Fondo2.jpg");
            this.BackgroundImage = img;


            listaclientes.Add(new Cliente(1231,"Alejandro Medina"));
            listaclientes.Add(new Cliente(1232, "Eva Medina"));
            listaclientes.Add(new Cliente(1233, "Romina Medina"));
            listaclientes.Add(new Cliente(1234, "Rosa Medina"));
            listaclientes.Add(new Cliente(1235, "Armando Medina"));
            listaclientes.Add(new Cliente(1236, "Lucas Medina"));
            listaclientes.Add(new Cliente(1237, "Fernando Medina"));
            listaclientes.Add(new Cliente(1238, "Javier Medina"));
            listaclientes.Add(new Cliente(1239, "Benjamin Medina"));
            listaclientes.Add(new Cliente(1210, "Raychell Medina"));
            listaclientes.Add(new Cliente(1211, "Ashley Medina"));
            listaclientes.Add(new Cliente(1212, "Keyla Medina"));

            listaproductos.Add(new Producto(12345678,"galleta",1));
            listaproductos.Add(new Producto(12345679,"chocolate",5));
            listaproductos.Add(new Producto(12345680,"pastillas",1));
            listaproductos.Add(new Producto(12345681,"jabon",10));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ci = Int32.Parse(textBox3.Text);
            Cliente aux = listaclientes.Find(cliente => cliente.carnet == ci);
            if (aux != null)
            {
                textBox4.Text = aux.nombreCompleto;
            }
            else
            {
                MessageBox.Show("No se Encontro al cliente", "Venta de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int cod = Int32.Parse(textBox1.Text);
            Producto aux = listaproductos.Find(producto => producto.codigo == cod);
            if (aux != null)
            {
                textBox5.Text = aux.descripcion;
                textBox6.Text = aux.precio.ToString();
            }
            else
            {
                MessageBox.Show("No se Encontro el producto", "Venta de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(sender, e);
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            int cant = Int32.Parse(textBox2.Text);
            int cod = Int32.Parse(textBox1.Text);
            Producto aux = listaproductos.Find(producto => producto.codigo == cod);
            float subt = cant * aux.precio;
            if (aux != null)
            {

                //MessageBox.Show(cant + " " + aux.descripcion + " precio unit. " + aux.precio.ToString() + " SubTotal" + cant * aux.precio, "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.Rows.Add(cant.ToString(), aux.descripcion, aux.precio.ToString(), subt.ToString());
                
            }

        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click_1(sender, e);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            
    }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

