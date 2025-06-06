using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Infoventas : Form
    {
        private service service;

        public Infoventas()
        {
            InitializeComponent();
            this.service = new service(new Tienda(new List<Persona>(), new List<Materiales>(), new List<Inventario>()));

           text_Isbn.Visible = false;
           textBox_ISBN.Visible = false;
           button_buscar_transa.Visible = false;
        }


        private void button_Transacciones_Click(object sender, EventArgs e)
        {
            text_Isbn.Visible = true;
            textBox_ISBN.Visible = true;
            button_buscar_transa.Visible = true;
        }

        private void button_buscar_transa_Click(object sender, EventArgs e)
        {
            int ISBN;
            if(!int.TryParse(textBox_ISBN.Text, out ISBN))
            {
                MessageBox.Show("Por favor, ingrese un ISBN válido.");
                return;
            }
            service.Transacciones_abastecimineto(ISBN);
            Materiales material = service.BuscarMaterial_For_ID(ISBN);
            MessageBox.Show($"El libro con ISBN {ISBN} tiene {material.Cantidadregistrada} transacciones de abastecimiento.");

            // Ocultar los controles después de la búsqueda
            text_Isbn.Visible = false;
            textBox_ISBN.Visible = false;
            button_buscar_transa.Visible = false;
        }

        private void button_mas_costoso_Click(object sender, EventArgs e)
        {
            service.MostrarLibrosMasCaros();
        }

        private void button_menos_costoso_Click(object sender, EventArgs e)
        {
            service.MostrarLibrosmenosCostoso();
        }

        private void button_mas_vendido_Click(object sender, EventArgs e)
        {
            service.Buscar_Libro_vendido();
        }
    }
}
