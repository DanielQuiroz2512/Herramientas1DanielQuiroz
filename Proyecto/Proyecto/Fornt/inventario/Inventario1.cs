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
    public partial class Inventario1 : Form
    {
        public Inventario1()
        {
            InitializeComponent();
        }

        private void Inventario1_Load(object sender, EventArgs e)
        {
            textBox4.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Registrar_libros_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true; // Mostramos al hacer clic
        }

        private void text_ISBN(object sender, EventArgs e)
        {

        }

        private void Textbox_ISBN(object sender, EventArgs e)
        {

        }
    }
}
