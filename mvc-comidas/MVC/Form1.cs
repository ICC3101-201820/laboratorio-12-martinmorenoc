using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Modelo;

namespace MVC
{
    public delegate void AgregarComidaDelegate(string nombre, int proteinas, int grasas, int carbohidratos);
    public delegate void EliminarComidaDelegate(Comida comida);

    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate OnAgregarComida;
        public event EliminarComidaDelegate OnEliminarComida;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hay suscritos?
            if (OnAgregarComida != null)
            {
                // Notificar a los suscritos
                OnAgregarComida.Invoke(nombreTextBox.Text, Int32.Parse(proteinasTextBox.Text), Int32.Parse(grasasTextBox.Text), Int32.Parse(carbohidratosTextBox.Text));
            }
        }

        public void AgregarComida(Comida comida)
        {
            comidasList.Items.Add(comida);
            
        }

        public void EliminarComida(Comida comida)
        {
            comidasList.Items.Remove(comida);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            ArrayList vSelectedItems = new ArrayList(comidasList.SelectedItems);
            foreach (Comida item in vSelectedItems)
            {
                OnEliminarComida.Invoke(item);
            }
        }
    }
}
