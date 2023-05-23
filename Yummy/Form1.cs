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

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Inserte datos por favor");
                return;
            }
            else
            {
                textBox1.Focus();
                lista.crearLista(textBox1.Text, int.Parse(textBox2.Text));
                textBox1.Clear();
                textBox2.Clear();
            }
        }


        private void Eliminar_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (lista.vacia())
            {
                MessageBox.Show("No hay elementos para eliminar");
                return;
            }
            else
            {
                if (textBox1.Text != "")
                {
                    lista.eliminarLista(textBox1.Text);
                }
                else
                    MessageBox.Show("Lista esta vacia");
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            if (lista.vacia())
            {
                MessageBox.Show("Lista vacia");
            }
            else
            {



                Nodo t;
                t = lista.getCursor();
                if (t == lista.primero)
                {
                    MessageBox.Show("No existe elemento anterior, se encuentra al principio de la lista");
                    return;
                }
                else
                {
                    t = lista.getAntCursor();
                    textBox1.Text = ((NodoPedido)t).damePedido();
                    textBox2.Text = ((NodoPedido)t).dameCantidad().ToString();
                    lista.cursor = t;
                    return;
                }


            }
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (lista.vacia())
            {
                MessageBox.Show("Lista vacia");
            }
            else
            {
                Nodo x;
                x = lista.getCursor();
                if (x == lista.ultimo)
                {
                    MessageBox.Show("No existe elemento siguiente, se encuentra al final de la lista");
                    return;
                }
                else
                {
                    x = lista.getProxCursor();
                    textBox1.Text = ((NodoPedido)x).damePedido();
                    textBox2.Text = ((NodoPedido)x).dameCantidad().ToString();
                    lista.cursor = x;
                    return;
                }
            }
        }

        private void Primero_Click(object sender, EventArgs e)
        {
            if (lista.vacia())
                MessageBox.Show("Lista vacia");
            else
            {
                Nodo m;
                m = lista.getPrimero();
                MessageBox.Show("Primer elemento: " + ((NodoPedido)m).damePedido());
            }
        }

        private void Último_Click(object sender, EventArgs e)
        {
            if (lista.vacia())
                MessageBox.Show("Lista vacia");
            else
            {
                Nodo ab;
                ab = lista.getUltimo();
                MessageBox.Show("Ultimo elemento: " + ((NodoPedido)ab).damePedido());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //if (textBox1.Text == "" || textBox2.Text == "")
            //{
            //    MessageBox.Show("Inserte datos por favor");
            //    return;
            //}
            //else
            //{
                //textBox1.Focus();
                //lista.crearLista(textBox1.Text, int.Parse(textBox2.Text));
                //textBox1.Clear();
                //textBox2.Clear();

                listaclientes.Add(new Cliente( int.Parse(textBox3.Text), textBox4.Text ));
            MessageBox.Show("Cliente registrado");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ci = Int32.Parse(textBox4.Text);
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

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ci = Int32.Parse(  textBox3.Text);
            Cliente aux = listaclientes.Find(cliente => cliente.carnet == ci);
            if(aux != null)
            {
                textBox4.Text = aux.nombreCompleto;
            }
            else
            {
                MessageBox.Show("No se Encontro al cliente", "Venta de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button3_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
