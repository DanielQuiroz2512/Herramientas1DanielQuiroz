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
    public partial class inventari : Form
    {
        private service service;
        private Form1 Form1;
        private Admin Admin;

        public inventari()
        {
            InitializeComponent();
            this.service = new service(new Tienda(new List<Persona>(), new List<Materiales>(), new List<Inventario>()));
        }

        private void inventari_Load(object sender, EventArgs e)
        {
            Texto_Titulo.Visible = false;
            textBox_ISBN.Visible = false;
            text_Titutlo.Visible = false;
            textBox_Titulo.Visible = false;
            text_Precio_de_compra.Visible = false;
            textBox_Precio_de_Compra.Visible = false;
            text_Precio_de_venta.Visible = false;
            textBox_Precio_de_venta.Visible = false;
            button_Registrar.Visible = false;
            button_Eliminar.Visible = false;
            button_buscar_name.Visible = false;
            button_buscar_ISBN.Visible = false;

        }

        private void textBox_ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Registrar_libro_Click(object sender, EventArgs e)
        {
            Texto_Titulo.Visible = true;
            textBox_ISBN.Visible = true;
            text_Titutlo.Visible = true;
            textBox_Titulo.Visible = true;
            text_Precio_de_compra.Visible = true;
            textBox_Precio_de_Compra.Visible = true;
            text_Precio_de_venta.Visible = true;
            textBox_Precio_de_venta.Visible = true;
            button_Registrar.Visible = true;
        }

        private void button_Registrar_Click(object sender, EventArgs e)
        {

            string Titulo = Texto_Titulo.Text;
            int ISBN, Precio_compra, Precio_venta;
            if (Titulo == "")
            {
                MessageBox.Show("Debes ingresar un Titulo");
                return;
            }
            if (!int.TryParse(textBox_ISBN.Text, out ISBN))
            {
                MessageBox.Show("Debes ingresar un ISBN valido");
                return;
            }
            if (!int.TryParse(textBox_Precio_de_Compra.Text, out Precio_compra))
            {
                MessageBox.Show("Debes ingresar un Precio de compra valido");
                return;
            }
            if (!int.TryParse(textBox_Precio_de_venta.Text, out Precio_venta))
            {
                MessageBox.Show("Debes ingresar un Precio de venta valido");
                return;
            }
            if (Precio_compra <= 0 || Precio_venta <= 0)
            {
                MessageBox.Show("Los precios deben ser mayores a cero");
                return;
            }
            if (Precio_venta < Precio_compra)
            {
                MessageBox.Show("El precio de venta no puede ser menor que el precio de compra");
                return;
            }
            Materiales libro = new Materiales(Titulo, ISBN, Precio_compra, Precio_venta, 0, 0, 0);
            MessageBox.Show("Libro registrado correctamente");
            //Limpiar campos de texto
            textBox_ISBN.ResetText();
            textBox_Titulo.ResetText();
            textBox_Precio_de_Compra.ResetText();
            textBox_Precio_de_venta.ResetText();
            // Se ocultan los compatos despues del registro

            Texto_Titulo.Visible = false;
            textBox_ISBN.Visible = false;
            text_Titutlo.Visible = false;
            textBox_Titulo.Visible = false;
            text_Precio_de_compra.Visible = false;
            textBox_Precio_de_Compra.Visible = false;
            text_Precio_de_venta.Visible = false;
            textBox_Precio_de_venta.Visible = false;
            button_Registrar.Visible = false;

        }

        private void button_Eliminar_Libro_Click(object sender, EventArgs e)
        {
            textBox_ISBN.Visible = true;
            button_Eliminar.Visible = true;
            Texto_Titulo.Visible = true;
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            int isbn;
            if (!int.TryParse(textBox_ISBN.Text, out isbn))
            {
                MessageBox.Show("Debes ingresar un ISBN valido");
                return;
            }
            if (isbn <= 0)
            {
                MessageBox.Show("El ISBN debe ser un numero positivo");
                return;
            }
            string mensaje = service.EliminarMaterial(isbn);
            MessageBox.Show(mensaje);
            textBox_ISBN.Visible = false;
            button_Eliminar.Visible = false;
            Texto_Titulo.Visible = false;

        }

        private void button_Finalizar_Click(object sender, EventArgs e)
        {
            Form1 hola = new Form1();
            Admin hol2 = new Admin();
            hola.Close();
            hol2.Close();
            this.Close();
        }

        private void button_Buscar_por_Titulo_Click(object sender, EventArgs e)
        {
            text_Titutlo.Visible = true;
            textBox_Titulo.Visible = true;
            button_buscar_name.Visible = true;
            
        }

        private void button_buscar_name_Click(object sender, EventArgs e)
        {
            string titulo = textBox_Titulo.Text;

            if (string.IsNullOrWhiteSpace(titulo))
            {
                MessageBox.Show("Debes ingresar un título válido.");
                return;
            }

            Materiales libro = service.BuscarMaterial_For_name(titulo);

            if (libro == null)
            {
                MessageBox.Show("No se encontró un libro con ese título.");
            }
            else
            {
                MessageBox.Show($"Libro encontrado:\nTítulo: {libro.Titulo1}\nISBN: {libro.ISBN1}");
            }
        }

        private void button_Buscar_por_ISBN_Click(object sender, EventArgs e)
        {
            textBox_ISBN.Visible = true;
            Texto_Titulo.Visible = true;
            button_buscar_ISBN.Visible = true;

        }

        private void button_buscar_ISBN_Click(object sender, EventArgs e)
        {
            int isbn;
            if (!int.TryParse(textBox_ISBN.Text, out isbn))
            {
                MessageBox.Show("Debes ingresar un ISBN válido");
                return;
            }
            if (isbn <= 0)
            {
                MessageBox.Show("El ISBN debe ser un número positivo");
                return;
            }
            Materiales libro = service.BuscarMaterial_For_ID(isbn);

            if (libro == null)
            {
                MessageBox.Show("No se encontró un libro con ese ISBN.");
            }
            else
            {
                MessageBox.Show($"Título: {libro.Titulo1}\nISBN: {libro.ISBN1}\nPrecio de venta: {libro.Precio_venta}");
            }

            textBox_ISBN.Visible = false;
            Texto_Titulo.Visible = false;
            button_buscar_ISBN.Visible = false;
        }

        private void button_Abastecimiento_Click(object sender, EventArgs e)
        {

        }
    }
}
