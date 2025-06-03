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
    public partial class Form1 : Form
    {
        private service service;
        public Form1()
        {
            InitializeComponent();
            this.service = new service(new Tienda(new List<Persona>(), new List<Materiales>(),new List<Inventario>()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string cedula = Cedula.Text;
            string rol = Rol.Text;
            if (nombre == "")
            {
                MessageBox.Show("Debes ingresar un nombre");
                return;
            }
            if (cedula == "")
            {
                MessageBox.Show("Debes ingresar una Cedula");
                return;
            }
            if (rol == "")
            {
                MessageBox.Show("Debes seleccionar un rol");
                return;
            }
            Persona persona = new Persona(nombre, cedula, rol);
            MessageBox.Show(this.service.crearpersona(persona));
            Nombre.ResetText();
            Cedula.ResetText();
            Rol.ResetText();

            // Abrir la interfaz principal y ocultar el formulario actual

            if (rol == "Admin")
            {
                Admin menu = new Admin();
                this.Hide();
                menu.Show();
            }
            else if (rol == "Cajero")
            {
                Usuario Menucajera = new Usuario();
                this.Hide();
                Menucajera.Show();
            }
            else
            {
                MessageBox.Show("El rol seleccionado no es valido, por favor seleccione una de las opciones permitidas");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
